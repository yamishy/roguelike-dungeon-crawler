
namespace DungeonCrawler
{
    partial class Game
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
            this.encounterLabel = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.encounterPrompt = new System.Windows.Forms.RichTextBox();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.actionLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.inventoryPanel = new System.Windows.Forms.Panel();
            this.inventoryList = new System.Windows.Forms.ListBox();
            this.playerInfo = new System.Windows.Forms.TextBox();
            this.actionTabButton = new System.Windows.Forms.Button();
            this.inventoryTabButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.sellQuantity = new System.Windows.Forms.NumericUpDown();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // encounterLabel
            // 
            this.encounterLabel.AutoSize = true;
            this.encounterLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.encounterLabel.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encounterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encounterLabel.Location = new System.Drawing.Point(12, 3);
            this.encounterLabel.Name = "encounterLabel";
            this.encounterLabel.Size = new System.Drawing.Size(307, 53);
            this.encounterLabel.TabIndex = 0;
            this.encounterLabel.Text = "Encounter Label";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backgroundPanel.Controls.Add(this.encounterPrompt);
            this.backgroundPanel.Controls.Add(this.actionsPanel);
            this.backgroundPanel.Controls.Add(this.inventoryPanel);
            this.backgroundPanel.Location = new System.Drawing.Point(21, 59);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(908, 445);
            this.backgroundPanel.TabIndex = 1;
            // 
            // encounterPrompt
            // 
            this.encounterPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encounterPrompt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.encounterPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encounterPrompt.Cursor = System.Windows.Forms.Cursors.Default;
            this.encounterPrompt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encounterPrompt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encounterPrompt.Location = new System.Drawing.Point(0, 0);
            this.encounterPrompt.Name = "encounterPrompt";
            this.encounterPrompt.ReadOnly = true;
            this.encounterPrompt.Size = new System.Drawing.Size(556, 445);
            this.encounterPrompt.TabIndex = 1;
            this.encounterPrompt.Text = "This is the encounter prompt. We can programatically edit this box. Just checking" +
    " to see if the line wraps.";
            // 
            // actionsPanel
            // 
            this.actionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.actionsPanel.Controls.Add(this.actionLayout);
            this.actionsPanel.Location = new System.Drawing.Point(559, 0);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(349, 445);
            this.actionsPanel.TabIndex = 0;
            // 
            // actionLayout
            // 
            this.actionLayout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.actionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLayout.Location = new System.Drawing.Point(0, 0);
            this.actionLayout.Name = "actionLayout";
            this.actionLayout.Size = new System.Drawing.Size(349, 445);
            this.actionLayout.TabIndex = 0;
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inventoryPanel.Controls.Add(this.moneyLabel);
            this.inventoryPanel.Controls.Add(this.sellQuantity);
            this.inventoryPanel.Controls.Add(this.sellButton);
            this.inventoryPanel.Controls.Add(this.inventoryList);
            this.inventoryPanel.Enabled = false;
            this.inventoryPanel.Location = new System.Drawing.Point(559, 0);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(349, 445);
            this.inventoryPanel.TabIndex = 2;
            this.inventoryPanel.Visible = false;
            // 
            // inventoryList
            // 
            this.inventoryList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.inventoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inventoryList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryList.FormattingEnabled = true;
            this.inventoryList.ItemHeight = 23;
            this.inventoryList.Location = new System.Drawing.Point(0, 54);
            this.inventoryList.Name = "inventoryList";
            this.inventoryList.Size = new System.Drawing.Size(349, 391);
            this.inventoryList.TabIndex = 0;
            this.inventoryList.SelectedIndexChanged += new System.EventHandler(this.inventoryList_SelectedIndexChanged);
            // 
            // playerInfo
            // 
            this.playerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerInfo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.playerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerInfo.Location = new System.Drawing.Point(580, 3);
            this.playerInfo.Multiline = true;
            this.playerInfo.Name = "playerInfo";
            this.playerInfo.Size = new System.Drawing.Size(349, 53);
            this.playerInfo.TabIndex = 2;
            this.playerInfo.Text = "Health: 10";
            this.playerInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // actionTabButton
            // 
            this.actionTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionTabButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTabButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actionTabButton.Location = new System.Drawing.Point(580, 28);
            this.actionTabButton.Name = "actionTabButton";
            this.actionTabButton.Size = new System.Drawing.Size(63, 23);
            this.actionTabButton.TabIndex = 3;
            this.actionTabButton.Text = "Actions";
            this.actionTabButton.UseVisualStyleBackColor = true;
            this.actionTabButton.Click += new System.EventHandler(this.actionTabButton_Click);
            // 
            // inventoryTabButton
            // 
            this.inventoryTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryTabButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTabButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventoryTabButton.Location = new System.Drawing.Point(649, 28);
            this.inventoryTabButton.Name = "inventoryTabButton";
            this.inventoryTabButton.Size = new System.Drawing.Size(63, 23);
            this.inventoryTabButton.TabIndex = 4;
            this.inventoryTabButton.Text = "Inventory";
            this.inventoryTabButton.UseVisualStyleBackColor = true;
            this.inventoryTabButton.Click += new System.EventHandler(this.inventoryTabButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sellButton.Location = new System.Drawing.Point(3, 3);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(63, 23);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // sellQuantity
            // 
            this.sellQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sellQuantity.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellQuantity.Location = new System.Drawing.Point(3, 32);
            this.sellQuantity.Name = "sellQuantity";
            this.sellQuantity.Size = new System.Drawing.Size(63, 21);
            this.sellQuantity.TabIndex = 5;
            this.sellQuantity.ValueChanged += new System.EventHandler(this.sellQuantity_ValueChanged);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(72, 34);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(0, 15);
            this.moneyLabel.TabIndex = 6;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(941, 561);
            this.Controls.Add(this.inventoryTabButton);
            this.Controls.Add(this.actionTabButton);
            this.Controls.Add(this.playerInfo);
            this.Controls.Add(this.encounterLabel);
            this.Controls.Add(this.backgroundPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Game";
            this.Text = "Dungeon Crawler";
            this.Load += new System.EventHandler(this.Game_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.inventoryPanel.ResumeLayout(false);
            this.inventoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encounterLabel;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.RichTextBox encounterPrompt;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.FlowLayoutPanel actionLayout;
        private System.Windows.Forms.TextBox playerInfo;
        private System.Windows.Forms.Panel inventoryPanel;
        private System.Windows.Forms.ListBox inventoryList;
        private System.Windows.Forms.Button actionTabButton;
        private System.Windows.Forms.Button inventoryTabButton;
        private System.Windows.Forms.NumericUpDown sellQuantity;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label moneyLabel;
    }
}