using System;
using System.Security;
using System.Windows.Forms;
using System.IO;

namespace ftp_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private bool validaInformacaoServidorFTP()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtEnderecoServido.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool validaInformacaoDownload()
        {
            if (string.IsNullOrEmpty(txtArquivoDownload.Text) || string.IsNullOrEmpty(txtBaixarPara.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnEnviarArquivo_Click(object sender, EventArgs e)
        {
            if (validaInformacaoServidorFTP())
            {
                if (!string.IsNullOrEmpty(txtArquivoUpload.Text))
                {

                    string ftpfullpath = "ftp://127.0.0.1:21/" + Path.GetFileName(txtArquivoUpload.Text);
                    try
                    {
                        FTP.EnviarArquivoFTP(txtArquivoUpload.Text, ftpfullpath, txtUsuario.Text, txtSenha.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informações do sevidor incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            //define as propriedades do controle 
            //OpenFileDialog
            ofd1.Multiselect = false;
            ofd1.Title = "Selecionar Arquivos";
            ofd1.InitialDirectory = @"C:\Dados\";
            //filtra para exibir todos arquivos
            ofd1.Filter = "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.RestoreDirectory = true;

            DialogResult dr = ofd1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    txtArquivoUpload.Text = ofd1.FileName;
                }
                catch (SecurityException ex)
                {
                    // O usuário  não possui permissão para ler arquivos
                    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                "Mensagem : " + ex.Message + "\n\n" +
                                                "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    // Não pode carregar a imagem (problemas de permissão)
                    MessageBox.Show("Você pode não ter permissão para ler o arquivo , ou " +
                                               " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                }
            }
        }

        private void btnBaixarArquivo_Click(object sender, EventArgs e)
        {

            if (validaInformacaoServidorFTP())
            {
                if (validaInformacaoDownload())
                {
                    try
                    {
                        FTP.BaixarArquivoFTP(txtArquivoDownload.Text, txtBaixarPara.Text, txtUsuario.Text, txtSenha.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Informações para download incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informações do sevidor incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
