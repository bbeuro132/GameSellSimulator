
namespace ClassGrade
{
    partial class GameSellSimulator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameListGrid = new System.Windows.Forms.DataGridView();
            this.BuyStuff = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertContent = new System.Windows.Forms.Button();
            this.showDialog = new System.Windows.Forms.Button();
            this.Save_or_Make_XML = new System.Windows.Forms.Button();
            this.Read_XML = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ProfitTextBox = new System.Windows.Forms.TextBox();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.GameTitle = new System.Windows.Forms.TextBox();
            this.GameModel = new System.Windows.Forms.TextBox();
            this.GameGenre = new System.Windows.Forms.TextBox();
            this.GamePrice = new System.Windows.Forms.TextBox();
            this.GameStock = new System.Windows.Forms.TextBox();
            this.ShowInfoBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GameListGrid
            // 
            this.GameListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GameListGrid.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GameListGrid.ColumnHeadersHeight = 25;
            this.GameListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyStuff});
            this.GameListGrid.Location = new System.Drawing.Point(268, 12);
            this.GameListGrid.Name = "GameListGrid";
            this.GameListGrid.Size = new System.Drawing.Size(475, 260);
            this.GameListGrid.TabIndex = 0;
            this.GameListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BuyStuff
            // 
            this.BuyStuff.HeaderText = "Buy";
            this.BuyStuff.Name = "BuyStuff";
            this.BuyStuff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BuyStuff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BuyStuff.Width = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "기종";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(120, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "장르";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(11, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(120, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "재고";
            // 
            // InsertContent
            // 
            this.InsertContent.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InsertContent.Location = new System.Drawing.Point(14, 231);
            this.InsertContent.Name = "InsertContent";
            this.InsertContent.Size = new System.Drawing.Size(128, 55);
            this.InsertContent.TabIndex = 15;
            this.InsertContent.Text = "기입하기";
            this.InsertContent.UseVisualStyleBackColor = true;
            this.InsertContent.Click += new System.EventHandler(this.InsertContent_Click);
            // 
            // showDialog
            // 
            this.showDialog.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showDialog.Location = new System.Drawing.Point(268, 294);
            this.showDialog.Name = "showDialog";
            this.showDialog.Size = new System.Drawing.Size(154, 53);
            this.showDialog.TabIndex = 16;
            this.showDialog.Text = "내용 표시하기";
            this.showDialog.UseVisualStyleBackColor = true;
            this.showDialog.Click += new System.EventHandler(this.button2_Click);
            // 
            // Save_or_Make_XML
            // 
            this.Save_or_Make_XML.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Save_or_Make_XML.Location = new System.Drawing.Point(428, 294);
            this.Save_or_Make_XML.Name = "Save_or_Make_XML";
            this.Save_or_Make_XML.Size = new System.Drawing.Size(161, 53);
            this.Save_or_Make_XML.TabIndex = 17;
            this.Save_or_Make_XML.Text = "XML 저장 및 새로만들기";
            this.Save_or_Make_XML.UseVisualStyleBackColor = true;
            this.Save_or_Make_XML.Click += new System.EventHandler(this.Save_or_Make_XML_Click);
            // 
            // Read_XML
            // 
            this.Read_XML.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Read_XML.Location = new System.Drawing.Point(595, 294);
            this.Read_XML.Name = "Read_XML";
            this.Read_XML.Size = new System.Drawing.Size(148, 53);
            this.Read_XML.TabIndex = 18;
            this.Read_XML.Text = "XML 읽기";
            this.Read_XML.UseVisualStyleBackColor = true;
            this.Read_XML.Click += new System.EventHandler(this.Read_XML_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuyButton.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BuyButton.Location = new System.Drawing.Point(595, 369);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(148, 53);
            this.BuyButton.TabIndex = 19;
            this.BuyButton.Text = "구입하기";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ProfitTextBox
            // 
            this.ProfitTextBox.Location = new System.Drawing.Point(14, 326);
            this.ProfitTextBox.Name = "ProfitTextBox";
            this.ProfitTextBox.Size = new System.Drawing.Size(138, 21);
            this.ProfitTextBox.TabIndex = 20;
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProfitLabel.Location = new System.Drawing.Point(9, 298);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(50, 25);
            this.ProfitLabel.TabIndex = 21;
            this.ProfitLabel.Text = "수익";
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Tomato;
            this.Delete_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete_Button.Location = new System.Drawing.Point(428, 369);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(161, 53);
            this.Delete_Button.TabIndex = 22;
            this.Delete_Button.Text = "선택 항목 삭제";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // GameTitle
            // 
            this.GameTitle.Location = new System.Drawing.Point(16, 56);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(225, 21);
            this.GameTitle.TabIndex = 23;
            // 
            // GameModel
            // 
            this.GameModel.Location = new System.Drawing.Point(17, 126);
            this.GameModel.Name = "GameModel";
            this.GameModel.Size = new System.Drawing.Size(100, 21);
            this.GameModel.TabIndex = 24;
            // 
            // GameGenre
            // 
            this.GameGenre.Location = new System.Drawing.Point(124, 126);
            this.GameGenre.Name = "GameGenre";
            this.GameGenre.Size = new System.Drawing.Size(117, 21);
            this.GameGenre.TabIndex = 25;
            // 
            // GamePrice
            // 
            this.GamePrice.Location = new System.Drawing.Point(16, 179);
            this.GamePrice.Name = "GamePrice";
            this.GamePrice.Size = new System.Drawing.Size(100, 21);
            this.GamePrice.TabIndex = 26;
            // 
            // GameStock
            // 
            this.GameStock.Location = new System.Drawing.Point(124, 178);
            this.GameStock.Name = "GameStock";
            this.GameStock.Size = new System.Drawing.Size(117, 21);
            this.GameStock.TabIndex = 27;
            // 
            // ShowInfoBTN
            // 
            this.ShowInfoBTN.BackColor = System.Drawing.Color.Honeydew;
            this.ShowInfoBTN.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowInfoBTN.Location = new System.Drawing.Point(268, 369);
            this.ShowInfoBTN.Name = "ShowInfoBTN";
            this.ShowInfoBTN.Size = new System.Drawing.Size(154, 53);
            this.ShowInfoBTN.TabIndex = 28;
            this.ShowInfoBTN.Text = "설명서";
            this.ShowInfoBTN.UseVisualStyleBackColor = false;
            this.ShowInfoBTN.Click += new System.EventHandler(this.ShowInfoBTN_Click);
            // 
            // GameSellSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.ShowInfoBTN);
            this.Controls.Add(this.GameStock);
            this.Controls.Add(this.GamePrice);
            this.Controls.Add(this.GameGenre);
            this.Controls.Add(this.GameModel);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.ProfitLabel);
            this.Controls.Add(this.ProfitTextBox);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.Read_XML);
            this.Controls.Add(this.Save_or_Make_XML);
            this.Controls.Add(this.showDialog);
            this.Controls.Add(this.InsertContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameListGrid);
            this.Name = "GameSellSimulator";
            this.Text = "게임 판매 매장 시뮬레이터 v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.GameListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GameListGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button InsertContent;
        private System.Windows.Forms.Button showDialog;
        private System.Windows.Forms.Button Save_or_Make_XML;
        private System.Windows.Forms.Button Read_XML;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BuyStuff;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.TextBox ProfitTextBox;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox GameTitle;
        private System.Windows.Forms.TextBox GameModel;
        private System.Windows.Forms.TextBox GameGenre;
        private System.Windows.Forms.TextBox GamePrice;
        private System.Windows.Forms.TextBox GameStock;
        private System.Windows.Forms.Button ShowInfoBTN;
    }
}

