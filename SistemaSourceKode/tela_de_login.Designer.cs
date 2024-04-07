
namespace SistemaSourceKode
{
    partial class tela_de_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_de_login));
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label nivelLabel;
            this.stucchiDataSet = new SistemaSourceKode.stucchiDataSet();
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter = new SistemaSourceKode.stucchiDataSetTableAdapters.cadastroTableAdapter();
            this.tableAdapterManager = new SistemaSourceKode.stucchiDataSetTableAdapters.TableAdapterManager();
            this.cadastroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.cadastroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nivelComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            nivelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stucchiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingNavigator)).BeginInit();
            this.cadastroBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // stucchiDataSet
            // 
            this.stucchiDataSet.DataSetName = "stucchiDataSet";
            this.stucchiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataMember = "cadastro";
            this.cadastroBindingSource.DataSource = this.stucchiDataSet;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastroTableAdapter = this.cadastroTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaSourceKode.stucchiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastroBindingNavigator
            // 
            this.cadastroBindingNavigator.AddNewItem = this.toolStripButton5;
            this.cadastroBindingNavigator.BindingSource = this.cadastroBindingSource;
            this.cadastroBindingNavigator.CountItem = this.toolStripLabel1;
            this.cadastroBindingNavigator.DeleteItem = this.toolStripButton6;
            this.cadastroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.cadastroBindingNavigatorSaveItem});
            this.cadastroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastroBindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.cadastroBindingNavigator.MoveLastItem = this.toolStripButton4;
            this.cadastroBindingNavigator.MoveNextItem = this.toolStripButton3;
            this.cadastroBindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.cadastroBindingNavigator.Name = "cadastroBindingNavigator";
            this.cadastroBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.cadastroBindingNavigator.Size = new System.Drawing.Size(676, 25);
            this.cadastroBindingNavigator.TabIndex = 0;
            this.cadastroBindingNavigator.Text = "bindingNavigator1";
            this.cadastroBindingNavigator.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Mover primeiro";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posição";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posição atual";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 15);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de itens";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton3.Text = "Mover próximo";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Adicionar novo";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton6.Text = "Excluir";
            // 
            // cadastroBindingNavigatorSaveItem
            // 
            this.cadastroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroBindingNavigatorSaveItem.Image")));
            this.cadastroBindingNavigatorSaveItem.Name = "cadastroBindingNavigatorSaveItem";
            this.cadastroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cadastroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadastroBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroBindingNavigatorSaveItem_Click);
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(161, 116);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(206, 113);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(121, 20);
            this.loginTextBox.TabIndex = 2;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(161, 142);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(206, 139);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(121, 20);
            this.senhaTextBox.TabIndex = 4;
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point(161, 168);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(36, 13);
            nivelLabel.TabIndex = 5;
            nivelLabel.Text = "Nível:";
            // 
            // nivelComboBox
            // 
            this.nivelComboBox.FormattingEnabled = true;
            this.nivelComboBox.Items.AddRange(new object[] {
            "ADM",
            "OPE"});
            this.nivelComboBox.Location = new System.Drawing.Point(206, 165);
            this.nivelComboBox.Name = "nivelComboBox";
            this.nivelComboBox.Size = new System.Drawing.Size(121, 21);
            this.nivelComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tela_de_login
            // 
            this.ClientSize = new System.Drawing.Size(493, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nivelLabel);
            this.Controls.Add(this.nivelComboBox);
            this.Controls.Add(this.cadastroBindingNavigator);
            this.Name = "tela_de_login";
            this.Load += new System.EventHandler(this.tela_de_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stucchiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingNavigator)).EndInit();
            this.cadastroBindingNavigator.ResumeLayout(false);
            this.cadastroBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource testeBindingSource;

        private System.Windows.Forms.BindingNavigator testeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton testeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView testeDataGridView;
        private stucchiDataSet stucchiDataSet;
        private System.Windows.Forms.BindingSource cadastroBindingSource;
        private stucchiDataSetTableAdapters.cadastroTableAdapter cadastroTableAdapter;
        private stucchiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cadastroBindingNavigatorSaveItem;
        public System.Windows.Forms.TextBox loginTextBox;
        public System.Windows.Forms.TextBox senhaTextBox;
        public System.Windows.Forms.ComboBox nivelComboBox;
        private System.Windows.Forms.Button button1;
    }
}