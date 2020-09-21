namespace ftp_image
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.informacoesUsuario = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEnderecoServido = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.arquivo = new System.Windows.Forms.GroupBox();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtArquivoUpload = new System.Windows.Forms.TextBox();
            this.labelArquivoUpload = new System.Windows.Forms.Label();
            this.download = new System.Windows.Forms.GroupBox();
            this.btnBaixarArquivo = new System.Windows.Forms.Button();
            this.labelBaixarPara = new System.Windows.Forms.Label();
            this.txtBaixarPara = new System.Windows.Forms.TextBox();
            this.txtArquivoDownload = new System.Windows.Forms.TextBox();
            this.labelArquivoDownload = new System.Windows.Forms.Label();
            this.informacoesUsuario.SuspendLayout();
            this.arquivo.SuspendLayout();
            this.download.SuspendLayout();
            this.SuspendLayout();
            // 
            // informacoesUsuario
            // 
            this.informacoesUsuario.Controls.Add(this.txtSenha);
            this.informacoesUsuario.Controls.Add(this.txtEnderecoServido);
            this.informacoesUsuario.Controls.Add(this.txtUsuario);
            this.informacoesUsuario.Controls.Add(this.labelEndereco);
            this.informacoesUsuario.Controls.Add(this.labelSenha);
            this.informacoesUsuario.Controls.Add(this.labelUsuario);
            this.informacoesUsuario.Location = new System.Drawing.Point(2, 13);
            this.informacoesUsuario.Name = "informacoesUsuario";
            this.informacoesUsuario.Size = new System.Drawing.Size(796, 113);
            this.informacoesUsuario.TabIndex = 0;
            this.informacoesUsuario.TabStop = false;
            this.informacoesUsuario.Text = "Servidor FTP";
            this.informacoesUsuario.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(464, 39);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(289, 23);
            this.txtSenha.TabIndex = 5;
            // 
            // txtEnderecoServido
            // 
            this.txtEnderecoServido.Location = new System.Drawing.Point(109, 80);
            this.txtEnderecoServido.Name = "txtEnderecoServido";
            this.txtEnderecoServido.Size = new System.Drawing.Size(644, 23);
            this.txtEnderecoServido.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(109, 39);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(289, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndereco.Location = new System.Drawing.Point(10, 75);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(93, 28);
            this.labelEndereco.TabIndex = 2;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSenha.Location = new System.Drawing.Point(405, 34);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(65, 28);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.Location = new System.Drawing.Point(24, 34);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 28);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // arquivo
            // 
            this.arquivo.Controls.Add(this.btnEnviarArquivo);
            this.arquivo.Controls.Add(this.btnProcurar);
            this.arquivo.Controls.Add(this.txtArquivoUpload);
            this.arquivo.Controls.Add(this.labelArquivoUpload);
            this.arquivo.Location = new System.Drawing.Point(2, 145);
            this.arquivo.Name = "arquivo";
            this.arquivo.Size = new System.Drawing.Size(791, 132);
            this.arquivo.TabIndex = 1;
            this.arquivo.TabStop = false;
            this.arquivo.Text = "Arquivo";
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEnviarArquivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviarArquivo.Location = new System.Drawing.Point(11, 94);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(774, 23);
            this.btnEnviarArquivo.TabIndex = 3;
            this.btnEnviarArquivo.Text = "Enviar arquivo";
            this.btnEnviarArquivo.UseVisualStyleBackColor = false;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.btnEnviarArquivo_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProcurar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcurar.Location = new System.Drawing.Point(747, 44);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(38, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Find";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtArquivoUpload
            // 
            this.txtArquivoUpload.Location = new System.Drawing.Point(10, 45);
            this.txtArquivoUpload.Name = "txtArquivoUpload";
            this.txtArquivoUpload.Size = new System.Drawing.Size(730, 23);
            this.txtArquivoUpload.TabIndex = 1;
            // 
            // labelArquivoUpload
            // 
            this.labelArquivoUpload.AutoSize = true;
            this.labelArquivoUpload.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArquivoUpload.Location = new System.Drawing.Point(11, 23);
            this.labelArquivoUpload.Name = "labelArquivoUpload";
            this.labelArquivoUpload.Size = new System.Drawing.Size(109, 19);
            this.labelArquivoUpload.TabIndex = 0;
            this.labelArquivoUpload.Text = "Arquivo a enviar";
            // 
            // download
            // 
            this.download.Controls.Add(this.btnBaixarArquivo);
            this.download.Controls.Add(this.labelBaixarPara);
            this.download.Controls.Add(this.txtBaixarPara);
            this.download.Controls.Add(this.txtArquivoDownload);
            this.download.Controls.Add(this.labelArquivoDownload);
            this.download.Location = new System.Drawing.Point(2, 298);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(791, 177);
            this.download.TabIndex = 2;
            this.download.TabStop = false;
            this.download.Text = "Download";
            // 
            // btnBaixarArquivo
            // 
            this.btnBaixarArquivo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBaixarArquivo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBaixarArquivo.Location = new System.Drawing.Point(24, 145);
            this.btnBaixarArquivo.Name = "btnBaixarArquivo";
            this.btnBaixarArquivo.Size = new System.Drawing.Size(753, 23);
            this.btnBaixarArquivo.TabIndex = 4;
            this.btnBaixarArquivo.Text = "Baixar Arquivo";
            this.btnBaixarArquivo.UseVisualStyleBackColor = false;
            this.btnBaixarArquivo.Click += new System.EventHandler(this.btnBaixarArquivo_Click);
            // 
            // labelBaixarPara
            // 
            this.labelBaixarPara.AutoSize = true;
            this.labelBaixarPara.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBaixarPara.Location = new System.Drawing.Point(5, 97);
            this.labelBaixarPara.Name = "labelBaixarPara";
            this.labelBaixarPara.Size = new System.Drawing.Size(76, 19);
            this.labelBaixarPara.TabIndex = 3;
            this.labelBaixarPara.Text = "Baixar para";
            // 
            // txtBaixarPara
            // 
            this.txtBaixarPara.Location = new System.Drawing.Point(82, 93);
            this.txtBaixarPara.Name = "txtBaixarPara";
            this.txtBaixarPara.Size = new System.Drawing.Size(695, 23);
            this.txtBaixarPara.TabIndex = 2;
            // 
            // txtArquivoDownload
            // 
            this.txtArquivoDownload.Location = new System.Drawing.Point(82, 33);
            this.txtArquivoDownload.Name = "txtArquivoDownload";
            this.txtArquivoDownload.Size = new System.Drawing.Size(695, 23);
            this.txtArquivoDownload.TabIndex = 1;
            // 
            // labelArquivoDownload
            // 
            this.labelArquivoDownload.AutoSize = true;
            this.labelArquivoDownload.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArquivoDownload.Location = new System.Drawing.Point(24, 37);
            this.labelArquivoDownload.Name = "labelArquivoDownload";
            this.labelArquivoDownload.Size = new System.Drawing.Size(57, 19);
            this.labelArquivoDownload.TabIndex = 0;
            this.labelArquivoDownload.Text = "Arquivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 509);
            this.Controls.Add(this.download);
            this.Controls.Add(this.arquivo);
            this.Controls.Add(this.informacoesUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.informacoesUsuario.ResumeLayout(false);
            this.informacoesUsuario.PerformLayout();
            this.arquivo.ResumeLayout(false);
            this.arquivo.PerformLayout();
            this.download.ResumeLayout(false);
            this.download.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox informacoesUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEnderecoServido;
        private System.Windows.Forms.GroupBox arquivo;
        private System.Windows.Forms.Label labelArquivoUpload;
        private System.Windows.Forms.TextBox txtArquivoUpload;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnEnviarArquivo;
        private System.Windows.Forms.GroupBox download;
        private System.Windows.Forms.Label labelArquivoDownload;
        private System.Windows.Forms.TextBox txtArquivoDownload;
        private System.Windows.Forms.TextBox txtBaixarPara;
        private System.Windows.Forms.Label labelBaixarPara;
        private System.Windows.Forms.Button btnBaixarArquivo;
    }
}

