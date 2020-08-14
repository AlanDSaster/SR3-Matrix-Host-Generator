namespace Shadowrun_Matrix_Host_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if(disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Element_SystemDifficulty = new System.Windows.Forms.ComboBox();
            this.ContextMenuStrip_formspace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.randomizeElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Element_SystemSecurityCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Element_SecurityRatingValue = new System.Windows.Forms.NumericUpDown();
            this.Element_SubsystemRating_Access = new System.Windows.Forms.NumericUpDown();
            this.Element_SubsystemRating_Index = new System.Windows.Forms.NumericUpDown();
            this.Element_SubsystemRating_Control = new System.Windows.Forms.NumericUpDown();
            this.Element_SubsystemRating_Slave = new System.Windows.Forms.NumericUpDown();
            this.Element_SubsystemRating_Files = new System.Windows.Forms.NumericUpDown();
            this.Element_Paydata_Points = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Element_Paydata_Size = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Element_Paydata_Defense = new System.Windows.Forms.TextBox();
            this.Element_NastySurprise = new System.Windows.Forms.TextBox();
            this.Element_Event1_NoAlert = new System.Windows.Forms.TextBox();
            this.Label_TriggerStepRange = new System.Windows.Forms.Label();
            this.Element_TriggerStepRange_1 = new System.Windows.Forms.NumericUpDown();
            this.Element_TriggerStepRange_2 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event2_NoAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_4 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event4_NoAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_3 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event3_NoAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_8 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event8_PassiveAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_7 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event7_PassiveAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_6 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event6_PassiveAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_5 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event5_PassiveAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_13 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event13_ActiveAlert_SystemShutdown = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_12 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event12_ActiveAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_11 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event11_ActiveAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_10 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event10_ActiveAlert = new System.Windows.Forms.TextBox();
            this.Element_TriggerStepRange_9 = new System.Windows.Forms.NumericUpDown();
            this.Element_Event9_ActiveAlert = new System.Windows.Forms.TextBox();
            this.Label_Event = new System.Windows.Forms.Label();
            this.Group_SecuritySheaf = new System.Windows.Forms.GroupBox();
            this.Group_SystemAttributes = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entireHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entireHostDifficultySectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hostDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostSecurityCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newHostAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entireHostAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.securityRatingValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSecuritySheafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entirePaydataSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.paydataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paydataSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paydataDefenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastySurpriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securitySheafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entireSheafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.stepRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roll1000D6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roll1000D3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Group_Paydata = new System.Windows.Forms.GroupBox();
            this.Group_NastySurprise = new System.Windows.Forms.GroupBox();
            this.Group_SystemDifficulty = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.toClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip_formspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SecurityRatingValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Access)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Slave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_Paydata_Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_Paydata_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_9)).BeginInit();
            this.Group_SecuritySheaf.SuspendLayout();
            this.Group_SystemAttributes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Group_Paydata.SuspendLayout();
            this.Group_NastySurprise.SuspendLayout();
            this.Group_SystemDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // Element_SystemDifficulty
            // 
            this.Element_SystemDifficulty.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_SystemDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Element_SystemDifficulty.FormattingEnabled = true;
            this.Element_SystemDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.Element_SystemDifficulty.Location = new System.Drawing.Point(121, 23);
            this.Element_SystemDifficulty.Name = "Element_SystemDifficulty";
            this.Element_SystemDifficulty.Size = new System.Drawing.Size(121, 21);
            this.Element_SystemDifficulty.TabIndex = 0;
            this.Element_SystemDifficulty.SelectedIndexChanged += new System.EventHandler(this.Element_SystemDifficulty_SelectedIndexChanged);
            // 
            // ContextMenuStrip_formspace
            // 
            this.ContextMenuStrip_formspace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeElementToolStripMenuItem,
            this.aboutThisElementToolStripMenuItem});
            this.ContextMenuStrip_formspace.Name = "ContextMenuStrip_formspace";
            this.ContextMenuStrip_formspace.Size = new System.Drawing.Size(180, 48);
            this.ContextMenuStrip_formspace.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // randomizeElementToolStripMenuItem
            // 
            this.randomizeElementToolStripMenuItem.Name = "randomizeElementToolStripMenuItem";
            this.randomizeElementToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.randomizeElementToolStripMenuItem.Text = "Randomize Element";
            this.randomizeElementToolStripMenuItem.Click += new System.EventHandler(this.RandomizeElementToolStripMenuItem_Click);
            // 
            // aboutThisElementToolStripMenuItem
            // 
            this.aboutThisElementToolStripMenuItem.Name = "aboutThisElementToolStripMenuItem";
            this.aboutThisElementToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutThisElementToolStripMenuItem.Text = "About This Element";
            // 
            // Element_SystemSecurityCode
            // 
            this.Element_SystemSecurityCode.AutoCompleteCustomSource.AddRange(new string[] {
            "Blue",
            "Green",
            "Orange",
            "Red"});
            this.Element_SystemSecurityCode.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_SystemSecurityCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Element_SystemSecurityCode.FormattingEnabled = true;
            this.Element_SystemSecurityCode.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Orange",
            "Red"});
            this.Element_SystemSecurityCode.Location = new System.Drawing.Point(121, 50);
            this.Element_SystemSecurityCode.Name = "Element_SystemSecurityCode";
            this.Element_SystemSecurityCode.Size = new System.Drawing.Size(121, 21);
            this.Element_SystemSecurityCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "System Security Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "System Difficulty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Access";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Security Rating Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Control";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Slave";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Files";
            // 
            // Element_SecurityRatingValue
            // 
            this.Element_SecurityRatingValue.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_SecurityRatingValue.Location = new System.Drawing.Point(121, 24);
            this.Element_SecurityRatingValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_SecurityRatingValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_SecurityRatingValue.Name = "Element_SecurityRatingValue";
            this.Element_SecurityRatingValue.Size = new System.Drawing.Size(121, 20);
            this.Element_SecurityRatingValue.TabIndex = 10;
            this.Element_SecurityRatingValue.Tag = "Security Rating Value";
            this.Element_SecurityRatingValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Element_SubsystemRating_Access
            // 
            this.Element_SubsystemRating_Access.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_SubsystemRating_Access.Location = new System.Drawing.Point(121, 50);
            this.Element_SubsystemRating_Access.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_SubsystemRating_Access.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_SubsystemRating_Access.Name = "Element_SubsystemRating_Access";
            this.Element_SubsystemRating_Access.Size = new System.Drawing.Size(121, 20);
            this.Element_SubsystemRating_Access.TabIndex = 11;
            this.Element_SubsystemRating_Access.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Element_SubsystemRating_Index
            // 
            this.Element_SubsystemRating_Index.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_SubsystemRating_Index.Location = new System.Drawing.Point(121, 102);
            this.Element_SubsystemRating_Index.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_SubsystemRating_Index.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_SubsystemRating_Index.Name = "Element_SubsystemRating_Index";
            this.Element_SubsystemRating_Index.Size = new System.Drawing.Size(121, 20);
            this.Element_SubsystemRating_Index.TabIndex = 13;
            this.Element_SubsystemRating_Index.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Element_SubsystemRating_Control
            // 
            this.Element_SubsystemRating_Control.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_SubsystemRating_Control.Location = new System.Drawing.Point(121, 76);
            this.Element_SubsystemRating_Control.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_SubsystemRating_Control.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_SubsystemRating_Control.Name = "Element_SubsystemRating_Control";
            this.Element_SubsystemRating_Control.Size = new System.Drawing.Size(121, 20);
            this.Element_SubsystemRating_Control.TabIndex = 12;
            this.Element_SubsystemRating_Control.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Element_SubsystemRating_Slave
            // 
            this.Element_SubsystemRating_Slave.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_SubsystemRating_Slave.Location = new System.Drawing.Point(121, 154);
            this.Element_SubsystemRating_Slave.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_SubsystemRating_Slave.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_SubsystemRating_Slave.Name = "Element_SubsystemRating_Slave";
            this.Element_SubsystemRating_Slave.Size = new System.Drawing.Size(121, 20);
            this.Element_SubsystemRating_Slave.TabIndex = 15;
            this.Element_SubsystemRating_Slave.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Element_SubsystemRating_Files
            // 
            this.Element_SubsystemRating_Files.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_SubsystemRating_Files.Location = new System.Drawing.Point(121, 128);
            this.Element_SubsystemRating_Files.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_SubsystemRating_Files.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_SubsystemRating_Files.Name = "Element_SubsystemRating_Files";
            this.Element_SubsystemRating_Files.Size = new System.Drawing.Size(121, 20);
            this.Element_SubsystemRating_Files.TabIndex = 14;
            this.Element_SubsystemRating_Files.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Element_Paydata_Points
            // 
            this.Element_Paydata_Points.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Paydata_Points.Location = new System.Drawing.Point(121, 24);
            this.Element_Paydata_Points.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_Paydata_Points.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_Paydata_Points.Name = "Element_Paydata_Points";
            this.Element_Paydata_Points.Size = new System.Drawing.Size(121, 20);
            this.Element_Paydata_Points.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Paydata Points";
            // 
            // Element_Paydata_Size
            // 
            this.Element_Paydata_Size.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Paydata_Size.Location = new System.Drawing.Point(121, 50);
            this.Element_Paydata_Size.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_Paydata_Size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_Paydata_Size.Name = "Element_Paydata_Size";
            this.Element_Paydata_Size.Size = new System.Drawing.Size(121, 20);
            this.Element_Paydata_Size.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Paydata Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Paydata Defense";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // Element_Paydata_Defense
            // 
            this.Element_Paydata_Defense.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Paydata_Defense.Location = new System.Drawing.Point(121, 76);
            this.Element_Paydata_Defense.Name = "Element_Paydata_Defense";
            this.Element_Paydata_Defense.Size = new System.Drawing.Size(119, 20);
            this.Element_Paydata_Defense.TabIndex = 22;
            this.Element_Paydata_Defense.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Element_NastySurprise
            // 
            this.Element_NastySurprise.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_NastySurprise.Location = new System.Drawing.Point(9, 19);
            this.Element_NastySurprise.Name = "Element_NastySurprise";
            this.Element_NastySurprise.Size = new System.Drawing.Size(231, 20);
            this.Element_NastySurprise.TabIndex = 24;
            // 
            // Element_Event1_NoAlert
            // 
            this.Element_Event1_NoAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event1_NoAlert.Location = new System.Drawing.Point(56, 45);
            this.Element_Event1_NoAlert.Name = "Element_Event1_NoAlert";
            this.Element_Event1_NoAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event1_NoAlert.TabIndex = 25;
            // 
            // Label_TriggerStepRange
            // 
            this.Label_TriggerStepRange.AutoSize = true;
            this.Label_TriggerStepRange.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Label_TriggerStepRange.Location = new System.Drawing.Point(6, 26);
            this.Label_TriggerStepRange.Name = "Label_TriggerStepRange";
            this.Label_TriggerStepRange.Size = new System.Drawing.Size(29, 13);
            this.Label_TriggerStepRange.TabIndex = 26;
            this.Label_TriggerStepRange.Text = "Step";
            // 
            // Element_TriggerStepRange_1
            // 
            this.Element_TriggerStepRange_1.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_1.Location = new System.Drawing.Point(9, 46);
            this.Element_TriggerStepRange_1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_1.Name = "Element_TriggerStepRange_1";
            this.Element_TriggerStepRange_1.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_1.TabIndex = 27;
            this.Element_TriggerStepRange_1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_TriggerStepRange_2
            // 
            this.Element_TriggerStepRange_2.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_2.Location = new System.Drawing.Point(9, 72);
            this.Element_TriggerStepRange_2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_2.Name = "Element_TriggerStepRange_2";
            this.Element_TriggerStepRange_2.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_2.TabIndex = 29;
            this.Element_TriggerStepRange_2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event2_NoAlert
            // 
            this.Element_Event2_NoAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event2_NoAlert.Location = new System.Drawing.Point(56, 71);
            this.Element_Event2_NoAlert.Name = "Element_Event2_NoAlert";
            this.Element_Event2_NoAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event2_NoAlert.TabIndex = 28;
            // 
            // Element_TriggerStepRange_4
            // 
            this.Element_TriggerStepRange_4.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_4.Location = new System.Drawing.Point(9, 124);
            this.Element_TriggerStepRange_4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_4.Name = "Element_TriggerStepRange_4";
            this.Element_TriggerStepRange_4.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_4.TabIndex = 33;
            this.Element_TriggerStepRange_4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event4_NoAlert
            // 
            this.Element_Event4_NoAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event4_NoAlert.Location = new System.Drawing.Point(56, 124);
            this.Element_Event4_NoAlert.Name = "Element_Event4_NoAlert";
            this.Element_Event4_NoAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event4_NoAlert.TabIndex = 32;
            // 
            // Element_TriggerStepRange_3
            // 
            this.Element_TriggerStepRange_3.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_3.Location = new System.Drawing.Point(9, 98);
            this.Element_TriggerStepRange_3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_3.Name = "Element_TriggerStepRange_3";
            this.Element_TriggerStepRange_3.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_3.TabIndex = 31;
            this.Element_TriggerStepRange_3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event3_NoAlert
            // 
            this.Element_Event3_NoAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event3_NoAlert.Location = new System.Drawing.Point(56, 98);
            this.Element_Event3_NoAlert.Name = "Element_Event3_NoAlert";
            this.Element_Event3_NoAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event3_NoAlert.TabIndex = 30;
            // 
            // Element_TriggerStepRange_8
            // 
            this.Element_TriggerStepRange_8.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_8.Location = new System.Drawing.Point(9, 229);
            this.Element_TriggerStepRange_8.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_8.Name = "Element_TriggerStepRange_8";
            this.Element_TriggerStepRange_8.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_8.TabIndex = 41;
            this.Element_TriggerStepRange_8.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event8_PassiveAlert
            // 
            this.Element_Event8_PassiveAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event8_PassiveAlert.Location = new System.Drawing.Point(56, 228);
            this.Element_Event8_PassiveAlert.Name = "Element_Event8_PassiveAlert";
            this.Element_Event8_PassiveAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event8_PassiveAlert.TabIndex = 40;
            // 
            // Element_TriggerStepRange_7
            // 
            this.Element_TriggerStepRange_7.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_7.Location = new System.Drawing.Point(9, 203);
            this.Element_TriggerStepRange_7.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_7.Name = "Element_TriggerStepRange_7";
            this.Element_TriggerStepRange_7.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_7.TabIndex = 39;
            this.Element_TriggerStepRange_7.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event7_PassiveAlert
            // 
            this.Element_Event7_PassiveAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event7_PassiveAlert.Location = new System.Drawing.Point(56, 202);
            this.Element_Event7_PassiveAlert.Name = "Element_Event7_PassiveAlert";
            this.Element_Event7_PassiveAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event7_PassiveAlert.TabIndex = 38;
            // 
            // Element_TriggerStepRange_6
            // 
            this.Element_TriggerStepRange_6.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_6.Location = new System.Drawing.Point(9, 177);
            this.Element_TriggerStepRange_6.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_6.Name = "Element_TriggerStepRange_6";
            this.Element_TriggerStepRange_6.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_6.TabIndex = 37;
            this.Element_TriggerStepRange_6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event6_PassiveAlert
            // 
            this.Element_Event6_PassiveAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event6_PassiveAlert.Location = new System.Drawing.Point(56, 176);
            this.Element_Event6_PassiveAlert.Name = "Element_Event6_PassiveAlert";
            this.Element_Event6_PassiveAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event6_PassiveAlert.TabIndex = 36;
            // 
            // Element_TriggerStepRange_5
            // 
            this.Element_TriggerStepRange_5.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_5.Location = new System.Drawing.Point(9, 151);
            this.Element_TriggerStepRange_5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_5.Name = "Element_TriggerStepRange_5";
            this.Element_TriggerStepRange_5.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_5.TabIndex = 35;
            this.Element_TriggerStepRange_5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event5_PassiveAlert
            // 
            this.Element_Event5_PassiveAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event5_PassiveAlert.Location = new System.Drawing.Point(56, 150);
            this.Element_Event5_PassiveAlert.Name = "Element_Event5_PassiveAlert";
            this.Element_Event5_PassiveAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event5_PassiveAlert.TabIndex = 34;
            this.Element_Event5_PassiveAlert.Text = "Passive Alert";
            // 
            // Element_TriggerStepRange_13
            // 
            this.Element_TriggerStepRange_13.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_13.Location = new System.Drawing.Point(9, 359);
            this.Element_TriggerStepRange_13.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_13.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_13.Name = "Element_TriggerStepRange_13";
            this.Element_TriggerStepRange_13.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_13.TabIndex = 51;
            this.Element_TriggerStepRange_13.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event13_ActiveAlert_SystemShutdown
            // 
            this.Element_Event13_ActiveAlert_SystemShutdown.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event13_ActiveAlert_SystemShutdown.Location = new System.Drawing.Point(56, 359);
            this.Element_Event13_ActiveAlert_SystemShutdown.Name = "Element_Event13_ActiveAlert_SystemShutdown";
            this.Element_Event13_ActiveAlert_SystemShutdown.Size = new System.Drawing.Size(284, 20);
            this.Element_Event13_ActiveAlert_SystemShutdown.TabIndex = 50;
            this.Element_Event13_ActiveAlert_SystemShutdown.Text = "System Shutdown";
            // 
            // Element_TriggerStepRange_12
            // 
            this.Element_TriggerStepRange_12.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_12.Location = new System.Drawing.Point(9, 333);
            this.Element_TriggerStepRange_12.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_12.Name = "Element_TriggerStepRange_12";
            this.Element_TriggerStepRange_12.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_12.TabIndex = 49;
            this.Element_TriggerStepRange_12.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event12_ActiveAlert
            // 
            this.Element_Event12_ActiveAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event12_ActiveAlert.Location = new System.Drawing.Point(56, 332);
            this.Element_Event12_ActiveAlert.Name = "Element_Event12_ActiveAlert";
            this.Element_Event12_ActiveAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event12_ActiveAlert.TabIndex = 48;
            // 
            // Element_TriggerStepRange_11
            // 
            this.Element_TriggerStepRange_11.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_11.Location = new System.Drawing.Point(9, 306);
            this.Element_TriggerStepRange_11.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_11.Name = "Element_TriggerStepRange_11";
            this.Element_TriggerStepRange_11.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_11.TabIndex = 47;
            this.Element_TriggerStepRange_11.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event11_ActiveAlert
            // 
            this.Element_Event11_ActiveAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event11_ActiveAlert.Location = new System.Drawing.Point(56, 306);
            this.Element_Event11_ActiveAlert.Name = "Element_Event11_ActiveAlert";
            this.Element_Event11_ActiveAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event11_ActiveAlert.TabIndex = 46;
            // 
            // Element_TriggerStepRange_10
            // 
            this.Element_TriggerStepRange_10.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_10.Location = new System.Drawing.Point(9, 280);
            this.Element_TriggerStepRange_10.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_10.Name = "Element_TriggerStepRange_10";
            this.Element_TriggerStepRange_10.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_10.TabIndex = 45;
            this.Element_TriggerStepRange_10.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event10_ActiveAlert
            // 
            this.Element_Event10_ActiveAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event10_ActiveAlert.Location = new System.Drawing.Point(56, 280);
            this.Element_Event10_ActiveAlert.Name = "Element_Event10_ActiveAlert";
            this.Element_Event10_ActiveAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event10_ActiveAlert.TabIndex = 44;
            // 
            // Element_TriggerStepRange_9
            // 
            this.Element_TriggerStepRange_9.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_TriggerStepRange_9.Location = new System.Drawing.Point(9, 255);
            this.Element_TriggerStepRange_9.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Element_TriggerStepRange_9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Element_TriggerStepRange_9.Name = "Element_TriggerStepRange_9";
            this.Element_TriggerStepRange_9.Size = new System.Drawing.Size(41, 20);
            this.Element_TriggerStepRange_9.TabIndex = 43;
            this.Element_TriggerStepRange_9.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Element_Event9_ActiveAlert
            // 
            this.Element_Event9_ActiveAlert.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Element_Event9_ActiveAlert.Location = new System.Drawing.Point(56, 254);
            this.Element_Event9_ActiveAlert.Name = "Element_Event9_ActiveAlert";
            this.Element_Event9_ActiveAlert.Size = new System.Drawing.Size(284, 20);
            this.Element_Event9_ActiveAlert.TabIndex = 42;
            this.Element_Event9_ActiveAlert.Text = "Active Alert";
            // 
            // Label_Event
            // 
            this.Label_Event.AutoSize = true;
            this.Label_Event.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Label_Event.Location = new System.Drawing.Point(53, 26);
            this.Label_Event.Name = "Label_Event";
            this.Label_Event.Size = new System.Drawing.Size(35, 13);
            this.Label_Event.TabIndex = 52;
            this.Label_Event.Text = "Event";
            // 
            // Group_SecuritySheaf
            // 
            this.Group_SecuritySheaf.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Group_SecuritySheaf.Controls.Add(this.Label_TriggerStepRange);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_1);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event13_ActiveAlert_SystemShutdown);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_13);
            this.Group_SecuritySheaf.Controls.Add(this.Label_Event);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_2);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_12);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event1_NoAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event12_ActiveAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event2_NoAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event11_ActiveAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_11);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_3);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event3_NoAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_10);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event4_NoAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_9);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event10_ActiveAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_8);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event5_PassiveAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_7);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event6_PassiveAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_6);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event9_ActiveAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_5);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event7_PassiveAlert);
            this.Group_SecuritySheaf.Controls.Add(this.Element_TriggerStepRange_4);
            this.Group_SecuritySheaf.Controls.Add(this.Element_Event8_PassiveAlert);
            this.Group_SecuritySheaf.Location = new System.Drawing.Point(294, 32);
            this.Group_SecuritySheaf.Name = "Group_SecuritySheaf";
            this.Group_SecuritySheaf.Size = new System.Drawing.Size(346, 387);
            this.Group_SecuritySheaf.TabIndex = 54;
            this.Group_SecuritySheaf.TabStop = false;
            this.Group_SecuritySheaf.Text = "Security Sheaf";
            this.Group_SecuritySheaf.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Group_SystemAttributes
            // 
            this.Group_SystemAttributes.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Group_SystemAttributes.Controls.Add(this.label3);
            this.Group_SystemAttributes.Controls.Add(this.label4);
            this.Group_SystemAttributes.Controls.Add(this.label6);
            this.Group_SystemAttributes.Controls.Add(this.label5);
            this.Group_SystemAttributes.Controls.Add(this.label8);
            this.Group_SystemAttributes.Controls.Add(this.label7);
            this.Group_SystemAttributes.Controls.Add(this.Element_SecurityRatingValue);
            this.Group_SystemAttributes.Controls.Add(this.Element_SubsystemRating_Slave);
            this.Group_SystemAttributes.Controls.Add(this.Element_SubsystemRating_Access);
            this.Group_SystemAttributes.Controls.Add(this.Element_SubsystemRating_Files);
            this.Group_SystemAttributes.Controls.Add(this.Element_SubsystemRating_Control);
            this.Group_SystemAttributes.Controls.Add(this.Element_SubsystemRating_Index);
            this.Group_SystemAttributes.Location = new System.Drawing.Point(12, 122);
            this.Group_SystemAttributes.Name = "Group_SystemAttributes";
            this.Group_SystemAttributes.Size = new System.Drawing.Size(276, 184);
            this.Group_SystemAttributes.TabIndex = 55;
            this.Group_SystemAttributes.TabStop = false;
            this.Group_SystemAttributes.Text = "Host Attributes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exportToTextFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entireHostToolStripMenuItem,
            this.toolStripSeparator1,
            this.newHostToolStripMenuItem,
            this.newHostAttributesToolStripMenuItem,
            this.newSecuritySheafToolStripMenuItem,
            this.nastySurpriseToolStripMenuItem,
            this.securitySheafToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "Randomize";
            // 
            // entireHostToolStripMenuItem
            // 
            this.entireHostToolStripMenuItem.Name = "entireHostToolStripMenuItem";
            this.entireHostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entireHostToolStripMenuItem.Text = "Entire Host";
            this.entireHostToolStripMenuItem.Click += new System.EventHandler(this.EntireHostToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // newHostToolStripMenuItem
            // 
            this.newHostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entireHostDifficultySectionToolStripMenuItem,
            this.toolStripSeparator2,
            this.hostDifficultyToolStripMenuItem,
            this.hostSecurityCodeToolStripMenuItem});
            this.newHostToolStripMenuItem.Name = "newHostToolStripMenuItem";
            this.newHostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newHostToolStripMenuItem.Text = "Host Difficulty";
            // 
            // entireHostDifficultySectionToolStripMenuItem
            // 
            this.entireHostDifficultySectionToolStripMenuItem.Name = "entireHostDifficultySectionToolStripMenuItem";
            this.entireHostDifficultySectionToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.entireHostDifficultySectionToolStripMenuItem.Text = "Entire Host Difficulty Section";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // hostDifficultyToolStripMenuItem
            // 
            this.hostDifficultyToolStripMenuItem.Name = "hostDifficultyToolStripMenuItem";
            this.hostDifficultyToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.hostDifficultyToolStripMenuItem.Text = "Host Difficulty";
            this.hostDifficultyToolStripMenuItem.Click += new System.EventHandler(this.HostDifficultyToolStripMenuItem_Click);
            // 
            // hostSecurityCodeToolStripMenuItem
            // 
            this.hostSecurityCodeToolStripMenuItem.Name = "hostSecurityCodeToolStripMenuItem";
            this.hostSecurityCodeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.hostSecurityCodeToolStripMenuItem.Text = "Host Security Code";
            // 
            // newHostAttributesToolStripMenuItem
            // 
            this.newHostAttributesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entireHostAttributesToolStripMenuItem,
            this.toolStripSeparator3,
            this.securityRatingValueToolStripMenuItem,
            this.accessToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.slaveToolStripMenuItem});
            this.newHostAttributesToolStripMenuItem.Name = "newHostAttributesToolStripMenuItem";
            this.newHostAttributesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newHostAttributesToolStripMenuItem.Text = "Host Attributes";
            // 
            // entireHostAttributesToolStripMenuItem
            // 
            this.entireHostAttributesToolStripMenuItem.Name = "entireHostAttributesToolStripMenuItem";
            this.entireHostAttributesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.entireHostAttributesToolStripMenuItem.Text = "Entire Host Attributes";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // securityRatingValueToolStripMenuItem
            // 
            this.securityRatingValueToolStripMenuItem.Name = "securityRatingValueToolStripMenuItem";
            this.securityRatingValueToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.securityRatingValueToolStripMenuItem.Text = "Security Rating Value";
            // 
            // accessToolStripMenuItem
            // 
            this.accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            this.accessToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.accessToolStripMenuItem.Text = "Access";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.indexToolStripMenuItem.Text = "Index";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // slaveToolStripMenuItem
            // 
            this.slaveToolStripMenuItem.Name = "slaveToolStripMenuItem";
            this.slaveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.slaveToolStripMenuItem.Text = "Slave";
            // 
            // newSecuritySheafToolStripMenuItem
            // 
            this.newSecuritySheafToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entirePaydataSectionToolStripMenuItem,
            this.toolStripSeparator4,
            this.paydataPointsToolStripMenuItem,
            this.paydataSizeToolStripMenuItem,
            this.paydataDefenseToolStripMenuItem});
            this.newSecuritySheafToolStripMenuItem.Name = "newSecuritySheafToolStripMenuItem";
            this.newSecuritySheafToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newSecuritySheafToolStripMenuItem.Text = "Paydata";
            // 
            // entirePaydataSectionToolStripMenuItem
            // 
            this.entirePaydataSectionToolStripMenuItem.Name = "entirePaydataSectionToolStripMenuItem";
            this.entirePaydataSectionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.entirePaydataSectionToolStripMenuItem.Text = "Entire Paydata Section";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // paydataPointsToolStripMenuItem
            // 
            this.paydataPointsToolStripMenuItem.Name = "paydataPointsToolStripMenuItem";
            this.paydataPointsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.paydataPointsToolStripMenuItem.Text = "Paydata Points";
            // 
            // paydataSizeToolStripMenuItem
            // 
            this.paydataSizeToolStripMenuItem.Name = "paydataSizeToolStripMenuItem";
            this.paydataSizeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.paydataSizeToolStripMenuItem.Text = "Paydata Size";
            // 
            // paydataDefenseToolStripMenuItem
            // 
            this.paydataDefenseToolStripMenuItem.Name = "paydataDefenseToolStripMenuItem";
            this.paydataDefenseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.paydataDefenseToolStripMenuItem.Text = "Paydata Defense";
            // 
            // nastySurpriseToolStripMenuItem
            // 
            this.nastySurpriseToolStripMenuItem.Name = "nastySurpriseToolStripMenuItem";
            this.nastySurpriseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nastySurpriseToolStripMenuItem.Text = "Nasty Surprise";
            // 
            // securitySheafToolStripMenuItem
            // 
            this.securitySheafToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entireSheafToolStripMenuItem,
            this.toolStripSeparator5,
            this.stepRangeToolStripMenuItem,
            this.eventsToolStripMenuItem});
            this.securitySheafToolStripMenuItem.Name = "securitySheafToolStripMenuItem";
            this.securitySheafToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.securitySheafToolStripMenuItem.Text = "Security Sheaf";
            // 
            // entireSheafToolStripMenuItem
            // 
            this.entireSheafToolStripMenuItem.Name = "entireSheafToolStripMenuItem";
            this.entireSheafToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.entireSheafToolStripMenuItem.Text = "Entire Sheaf";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // stepRangeToolStripMenuItem
            // 
            this.stepRangeToolStripMenuItem.Name = "stepRangeToolStripMenuItem";
            this.stepRangeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.stepRangeToolStripMenuItem.Text = "Step Range";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // exportToTextFileToolStripMenuItem
            // 
            this.exportToTextFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asTextFileToolStripMenuItem,
            this.asSpreadsheetToolStripMenuItem,
            this.toClipboardToolStripMenuItem});
            this.exportToTextFileToolStripMenuItem.Name = "exportToTextFileToolStripMenuItem";
            this.exportToTextFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToTextFileToolStripMenuItem.Text = "Export";
            // 
            // asTextFileToolStripMenuItem
            // 
            this.asTextFileToolStripMenuItem.Name = "asTextFileToolStripMenuItem";
            this.asTextFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asTextFileToolStripMenuItem.Text = "To Text File";
            this.asTextFileToolStripMenuItem.Click += new System.EventHandler(this.AsTextFileToolStripMenuItem_Click);
            // 
            // asSpreadsheetToolStripMenuItem
            // 
            this.asSpreadsheetToolStripMenuItem.Name = "asSpreadsheetToolStripMenuItem";
            this.asSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asSpreadsheetToolStripMenuItem.Text = "To Spreadsheet";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.readMeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.readMeToolStripMenuItem.Text = "View Read Me";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roll1000D6ToolStripMenuItem,
            this.roll1000D3ToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // roll1000D6ToolStripMenuItem
            // 
            this.roll1000D6ToolStripMenuItem.Name = "roll1000D6ToolStripMenuItem";
            this.roll1000D6ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.roll1000D6ToolStripMenuItem.Text = "Roll1000D6";
            this.roll1000D6ToolStripMenuItem.Click += new System.EventHandler(this.Roll1000D6ToolStripMenuItem_Click);
            // 
            // roll1000D3ToolStripMenuItem
            // 
            this.roll1000D3ToolStripMenuItem.Name = "roll1000D3ToolStripMenuItem";
            this.roll1000D3ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.roll1000D3ToolStripMenuItem.Text = "Roll1000D3";
            this.roll1000D3ToolStripMenuItem.Click += new System.EventHandler(this.Roll1000D3ToolStripMenuItem_Click);
            // 
            // Group_Paydata
            // 
            this.Group_Paydata.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Group_Paydata.Controls.Add(this.label9);
            this.Group_Paydata.Controls.Add(this.Element_Paydata_Points);
            this.Group_Paydata.Controls.Add(this.label10);
            this.Group_Paydata.Controls.Add(this.Element_Paydata_Size);
            this.Group_Paydata.Controls.Add(this.label11);
            this.Group_Paydata.Controls.Add(this.Element_Paydata_Defense);
            this.Group_Paydata.Location = new System.Drawing.Point(12, 312);
            this.Group_Paydata.Name = "Group_Paydata";
            this.Group_Paydata.Size = new System.Drawing.Size(276, 107);
            this.Group_Paydata.TabIndex = 57;
            this.Group_Paydata.TabStop = false;
            this.Group_Paydata.Text = "Paydata";
            // 
            // Group_NastySurprise
            // 
            this.Group_NastySurprise.ContextMenuStrip = this.ContextMenuStrip_formspace;
            this.Group_NastySurprise.Controls.Add(this.Element_NastySurprise);
            this.Group_NastySurprise.Location = new System.Drawing.Point(12, 425);
            this.Group_NastySurprise.Name = "Group_NastySurprise";
            this.Group_NastySurprise.Size = new System.Drawing.Size(276, 47);
            this.Group_NastySurprise.TabIndex = 58;
            this.Group_NastySurprise.TabStop = false;
            this.Group_NastySurprise.Text = "Nasty Surprise";
            this.Group_NastySurprise.Enter += new System.EventHandler(this.GroupBox1_Enter_1);
            // 
            // Group_SystemDifficulty
            // 
            this.Group_SystemDifficulty.Controls.Add(this.label2);
            this.Group_SystemDifficulty.Controls.Add(this.label1);
            this.Group_SystemDifficulty.Controls.Add(this.Element_SystemSecurityCode);
            this.Group_SystemDifficulty.Controls.Add(this.Element_SystemDifficulty);
            this.Group_SystemDifficulty.Location = new System.Drawing.Point(12, 32);
            this.Group_SystemDifficulty.Name = "Group_SystemDifficulty";
            this.Group_SystemDifficulty.Size = new System.Drawing.Size(276, 84);
            this.Group_SystemDifficulty.TabIndex = 59;
            this.Group_SystemDifficulty.TabStop = false;
            this.Group_SystemDifficulty.Text = "Host Difficulty";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 61;
            this.button2.Text = "New Attributes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "New Host";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 63;
            this.button3.Text = "New Paydata";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 66;
            this.button4.Text = "New Sheaf";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(303, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 23);
            this.button5.TabIndex = 65;
            this.button5.Text = "New Surprise";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(411, 454);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 23);
            this.button6.TabIndex = 64;
            this.button6.Text = "New Step Range";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // toClipboardToolStripMenuItem
            // 
            this.toClipboardToolStripMenuItem.Name = "toClipboardToolStripMenuItem";
            this.toClipboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toClipboardToolStripMenuItem.Text = "To Clipboard";
            this.toClipboardToolStripMenuItem.Click += new System.EventHandler(this.ToClipboardToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 488);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Group_SystemDifficulty);
            this.Controls.Add(this.Group_NastySurprise);
            this.Controls.Add(this.Group_Paydata);
            this.Controls.Add(this.Group_SystemAttributes);
            this.Controls.Add(this.Group_SecuritySheaf);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shadowrun Matrix Host Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContextMenuStrip_formspace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Element_SecurityRatingValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Access)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Slave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_SubsystemRating_Files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_Paydata_Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_Paydata_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Element_TriggerStepRange_9)).EndInit();
            this.Group_SecuritySheaf.ResumeLayout(false);
            this.Group_SecuritySheaf.PerformLayout();
            this.Group_SystemAttributes.ResumeLayout(false);
            this.Group_SystemAttributes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Group_Paydata.ResumeLayout(false);
            this.Group_Paydata.PerformLayout();
            this.Group_NastySurprise.ResumeLayout(false);
            this.Group_NastySurprise.PerformLayout();
            this.Group_SystemDifficulty.ResumeLayout(false);
            this.Group_SystemDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Element_SystemDifficulty;
        private System.Windows.Forms.ComboBox Element_SystemSecurityCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Element_SecurityRatingValue;
        private System.Windows.Forms.NumericUpDown Element_SubsystemRating_Access;
        private System.Windows.Forms.NumericUpDown Element_SubsystemRating_Index;
        private System.Windows.Forms.NumericUpDown Element_SubsystemRating_Control;
        private System.Windows.Forms.NumericUpDown Element_SubsystemRating_Slave;
        private System.Windows.Forms.NumericUpDown Element_SubsystemRating_Files;
        private System.Windows.Forms.NumericUpDown Element_Paydata_Points;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Element_Paydata_Size;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Element_Paydata_Defense;
        private System.Windows.Forms.TextBox Element_NastySurprise;
        private System.Windows.Forms.TextBox Element_Event1_NoAlert;
        private System.Windows.Forms.Label Label_TriggerStepRange;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_1;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_2;
        private System.Windows.Forms.TextBox Element_Event2_NoAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_4;
        private System.Windows.Forms.TextBox Element_Event4_NoAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_3;
        private System.Windows.Forms.TextBox Element_Event3_NoAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_8;
        private System.Windows.Forms.TextBox Element_Event8_PassiveAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_7;
        private System.Windows.Forms.TextBox Element_Event7_PassiveAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_6;
        private System.Windows.Forms.TextBox Element_Event6_PassiveAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_5;
        private System.Windows.Forms.TextBox Element_Event5_PassiveAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_13;
        private System.Windows.Forms.TextBox Element_Event13_ActiveAlert_SystemShutdown;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_12;
        private System.Windows.Forms.TextBox Element_Event12_ActiveAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_11;
        private System.Windows.Forms.TextBox Element_Event11_ActiveAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_10;
        private System.Windows.Forms.TextBox Element_Event10_ActiveAlert;
        private System.Windows.Forms.NumericUpDown Element_TriggerStepRange_9;
        private System.Windows.Forms.TextBox Element_Event9_ActiveAlert;
        private System.Windows.Forms.Label Label_Event;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_formspace;
        private System.Windows.Forms.ToolStripMenuItem randomizeElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisElementToolStripMenuItem;
        private System.Windows.Forms.GroupBox Group_SecuritySheaf;
        private System.Windows.Forms.GroupBox Group_SystemAttributes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newHostAttributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSecuritySheafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.GroupBox Group_Paydata;
        private System.Windows.Forms.GroupBox Group_NastySurprise;
        private System.Windows.Forms.GroupBox Group_SystemDifficulty;
        private System.Windows.Forms.ToolStripMenuItem entireHostDifficultySectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostDifficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostSecurityCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entireHostAttributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityRatingValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entirePaydataSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paydataPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paydataSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paydataDefenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastySurpriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securitySheafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entireSheafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entireHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roll1000D6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roll1000D3ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem toClipboardToolStripMenuItem;
    }
}

