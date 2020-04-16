using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Zylix
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        { 
            tbl.Columns.Add("ID", typeof(string));
            tbl.Columns.Add("Descrição", typeof(string));
            tbl.Columns.Add("Valor", typeof(string));
            tbl.Columns.Add("Comentários", typeof(string));

            dataGridView1.DataSource = tbl;
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo texto |*.txt";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
                try
                {
                    {
                        // for lendo o grid e gravando
                        string[] linhas = File.ReadAllLines(ofd.FileName);
                        string[] valores;

                        for(int i = 0; i < linhas.Length; i++)
                        {
                            valores = linhas[i].ToString().Split(';');
                            string[] colunas = new string[valores.Length];

                            for (int j = 0; j < valores.Length; j++)
                            {
                                colunas[j] = valores[j].Trim();
                            }
                            tbl.Rows.Add(colunas);
                        }
                        //int aux = tabControl2.TabPages.Count;
                        tabControl2.TabPages[0].Name = ofd.SafeFileName;
                        tabControl2.Refresh();
                        tabControl2.Visible = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(String.Format("Não foi possível abrir seu arquivo. Erro: {0}", ex.Message), "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo texto |*.txt";
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName) == false)
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName,false,Encoding.UTF8))
                {
                    // for lendo o grid e gravando
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            writer.Write("; " + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        writer.WriteLine("");
                    }
                    MessageBox.Show("Arquivo exportado com sucesso para: " + sfd.FileName);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // limpa o grid
            tbl.Clear();

            if (e.Node.Name == "node1")
            {
                string[] linhas = File.ReadAllLines(System.Environment.CurrentDirectory + @"\diretorio_de_seguranca.txt");
                string[] valores;

                for (int i = 0; i < linhas.Length; i++)
                {
                    valores = linhas[i].ToString().Split(';');
                    string[] colunas = new string[valores.Length];

                    for (int j = 0; j < valores.Length; j++)
                    {
                        colunas[j] = valores[j].Trim();
                    }
                    tbl.Rows.Add(colunas);
                }
            }
            else if (e.Node.Name == "node2")
            {
                string[] linhas = File.ReadAllLines(System.Environment.CurrentDirectory + @"\proposito_geral.txt");
                string[] valores;

                for (int i = 0; i < linhas.Length; i++)
                {
                    valores = linhas[i].ToString().Split(';');
                    string[] colunas = new string[valores.Length];

                    for (int j = 0; j < valores.Length; j++)
                    {
                        colunas[j] = valores[j].Trim();
                    }
                    tbl.Rows.Add(colunas);
                }
            }
            else if (e.Node.Name == "node3")
            {
                string[] linhas = File.ReadAllLines(System.Environment.CurrentDirectory + @"\controle_de_fluxo.txt");
                string[] valores;

                for (int i = 0; i < linhas.Length; i++)
                {
                    valores = linhas[i].ToString().Split(';');
                    string[] colunas = new string[valores.Length];

                    for (int j = 0; j < valores.Length; j++)
                    {
                        colunas[j] = valores[j].Trim();
                    }
                    tbl.Rows.Add(colunas);
                }
            }
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            string caminho = System.Environment.CurrentDirectory+ @"\impressao.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            Paragraph titulo = new Paragraph();
            titulo.Font = new Font(new Font.FontFamily(),40);
            titulo.Alignment = Element.ALIGN_CENTER;
            
            // por alguma razão não puxa o titulo da aba ativa para imprimir
            string[] nomearq = tabControl2.SelectedTab.Name.Split('.');
            titulo.Add(nomearq[0] + "\n\n");

            PdfPTable table = new PdfPTable(tbl.Columns.Count);
            for (int i = 0; i < tbl.Rows.Count - 1; i++)
            {
                for (int j = 0; j < tbl.Columns.Count; j++)
                {
                    table.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
            doc.Add(table);
            doc.Close();
            System.Diagnostics.Process.Start(caminho);
        }
    }
}
