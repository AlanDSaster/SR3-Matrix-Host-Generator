using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadowrun_Matrix_Host_Generator {

    public partial class Form1 : Form {

        public Form1() {

            InitializeComponent();
            
        }

        private HostGenerator hostgen;

        private void Label11_Click( object sender, EventArgs e ) {

        }

        private void TextBox1_TextChanged( object sender, EventArgs e ) {

        }

        private void Form1_Load( object sender, EventArgs e ) {
            
            Element_SystemDifficulty.SelectedItem = "Easy";
            Element_SystemSecurityCode.SelectedItem = "Blue";
            hostgen = new HostGenerator();
        }

        private void ContextMenuStrip1_Opening( object sender, CancelEventArgs e ) {

            

        }

        private void RandomizeElementToolStripMenuItem_Click( object sender, EventArgs e ) {

            ToolStripItem menuItem = sender as ToolStripItem;

            string name;

            string systemdifficulty = Element_SystemDifficulty.Text;
            string systemsecuritycode = Element_SystemSecurityCode.Text;
            int securityratingvalue = Convert.ToInt32( Element_SecurityRatingValue.Value );

            if(menuItem != null) {

                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;

                if(owner != null) {

                    Control sourceControl = owner.SourceControl;

                    name = sourceControl.Name;

                    switch(name) {

                        case "Group_SystemAttributes":

                            RandomizeHostAttributes();
                            break;

                        case "Group_Paydata":

                            RandomizePaydata();
                            break;

                        case "Group_NastySurprise":
                            RandomizeNastySurprise();
                            break;

                        case "Group_SecuritySheaf":

                            break;

                        case "Element_SecurityRatingValue":
                            
                            Element_SecurityRatingValue.Value = hostgen.Generate_SecurityRatingValue( systemdifficulty );
                            break;

                        case "Element_SubsystemRating_Access":
                            Element_SubsystemRating_Access.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
                            break;

                        case "Element_SubsystemRating_Control":
                            Element_SubsystemRating_Control.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
                            break;

                        case "Element_SubsystemRating_Index":
                            Element_SubsystemRating_Index.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
                            break;

                        case "Element_SubsystemRating_Files":
                            Element_SubsystemRating_Files.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
                            break;

                        case "Element_SubsystemRating_Slave":
                            Element_SubsystemRating_Slave.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
                            break;

                        case "Element_Paydata_Points":
                            Element_Paydata_Points.Value = hostgen.Generate_PaydataPoints( systemsecuritycode );
                            break;

                        case "Element_Paydata_Size":
                            Element_Paydata_Size.Value = hostgen.Generate_PaydataSize( systemsecuritycode );
                            break;

                        case "Element_Paydata_Defense":
                            Element_Paydata_Defense.Text = hostgen.Generate_PaydataDefense( systemsecuritycode, securityratingvalue );
                            break;

                        case "Element_NastySurprise":
                            Element_NastySurprise.Text = hostgen.Generate_NastySurprise( securityratingvalue );
                            break;

                        case "Label_TriggerStepRange":
                            RandomizeTriggerStepRange();
                            break;

                        case "Label_Event":
                            RandomizeSecuritySheaf();
                            break;

                        case "Element_Event1_NoAlert":
                            Element_Event1_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
                            break;

                        case "Element_Event2_NoAlert":
                            Element_Event2_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
                            break;

                        case "Element_Event3_NoAlert":
                            Element_Event3_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
                            break;

                        case "Element_Event4_NoAlert":
                            Element_Event4_NoAlert.Text = hostgen.Generate_Events_NoAlert( "Passive Alert", securityratingvalue );
                            break;

                        case "Element_Event5_PassiveAlert":
                            Element_Event5_PassiveAlert.Text = "Passive Alert, " + hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
                            break;

                        case "Element_Event6_PassiveAlert":
                            Element_Event6_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
                            break;

                        case "Element_Event7_PassiveAlert":
                            Element_Event7_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
                            break;

                        case "Element_Event8_PassiveAlert":
                            Element_Event8_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
                            break;

                        case "Element_Event9_ActiveAlert":
                            Element_Event9_ActiveAlert.Text = "Active Alert, " + hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
                            break;

                        case "Element_Event10_ActiveAlert":
                            Element_Event10_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
                            break;

                        case "Element_Event11_ActiveAlert":
                            Element_Event11_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
                            break;

                        case "Element_Event12_ActiveAlert":
                            Element_Event12_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
                            break;

                        case "Element_Event13_ActiveAlert_SystemShutdown":
                            Element_Event13_ActiveAlert_SystemShutdown.Text = "Begin System Shutdown, " + hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
                            break;

                    }

                }

            }

        }

        private void GroupBox1_Enter( object sender, EventArgs e ) {

        }

        private void Element_SystemDifficulty_SelectedIndexChanged( object sender, EventArgs e ) {

        }

        private void GroupBox1_Enter_1( object sender, EventArgs e ) {

        }

        private void HostDifficultyToolStripMenuItem_Click( object sender, EventArgs e ) {

        }

        private void EntireHostToolStripMenuItem_Click( object sender, EventArgs e ) {

            RandomizeEntireHost();

        }

        
        private void Roll1000D6ToolStripMenuItem_Click( object sender, EventArgs e ) {

            for(int i = 0; i < 1000; i++) {

                Console.WriteLine( hostgen.Roll1D6() );
                
            }

            Console.WriteLine( "Complete" );

        }

        private void Roll1000D3ToolStripMenuItem_Click( object sender, EventArgs e ) {

            for(int i = 0; i < 1000; i++) {

                Console.WriteLine( hostgen.Roll1D3() );

            }

            Console.WriteLine( "Complete" );

        }

        private void Button1_Click( object sender, EventArgs e ) {

            RandomizeEntireHost();

        }

        private void RandomizeEntireHost() {

            string systemdifficulty = Element_SystemDifficulty.Text;
            string systemsecuritycode = Element_SystemSecurityCode.Text;

            Element_SecurityRatingValue.Value = hostgen.Generate_SecurityRatingValue( systemdifficulty );

            int securityratingvalue = Convert.ToInt32( Element_SecurityRatingValue.Value );

            Element_SubsystemRating_Access.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Control.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Index.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Files.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Slave.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_Paydata_Points.Value = hostgen.Generate_PaydataPoints( systemsecuritycode );
            Element_Paydata_Size.Value = hostgen.Generate_PaydataSize( systemsecuritycode );
            Element_Paydata_Defense.Text = hostgen.Generate_PaydataDefense( systemsecuritycode, securityratingvalue );
            Element_NastySurprise.Text = hostgen.Generate_NastySurprise( securityratingvalue );
            Element_SecurityRatingValue.Value = hostgen.Generate_SecurityRatingValue( systemdifficulty );
            Element_SubsystemRating_Access.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Control.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Index.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Files.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Slave.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_Paydata_Points.Value = hostgen.Generate_PaydataPoints( systemsecuritycode );
            Element_Paydata_Size.Value = hostgen.Generate_PaydataSize( systemsecuritycode );
            Element_Paydata_Defense.Text = hostgen.Generate_PaydataDefense( systemsecuritycode, securityratingvalue );
            Element_NastySurprise.Text = hostgen.Generate_NastySurprise( securityratingvalue );
            Element_TriggerStepRange_1.Value = hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_2.Value = Element_TriggerStepRange_1.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_3.Value = Element_TriggerStepRange_2.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_4.Value = Element_TriggerStepRange_3.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_5.Value = Element_TriggerStepRange_4.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_6.Value = Element_TriggerStepRange_5.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_7.Value = Element_TriggerStepRange_6.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_8.Value = Element_TriggerStepRange_7.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_9.Value = Element_TriggerStepRange_8.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_10.Value = Element_TriggerStepRange_9.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_11.Value = Element_TriggerStepRange_10.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_12.Value = Element_TriggerStepRange_11.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_13.Value = Element_TriggerStepRange_12.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_Event1_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event2_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event3_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event4_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event5_PassiveAlert.Text = "Passive Alert, " + hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event6_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event7_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event8_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event9_ActiveAlert.Text = "Active Alert, " + hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event10_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event11_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event12_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event13_ActiveAlert_SystemShutdown.Text = "Begin System Shutdown, " + hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event1_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event2_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event3_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event4_NoAlert.Text = hostgen.Generate_Events_NoAlert( "Passive Alert", securityratingvalue );
            Element_Event5_PassiveAlert.Text = "Passive Alert, " + hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event6_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event7_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event8_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event9_ActiveAlert.Text = "Active Alert, " + hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event10_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event11_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event12_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event13_ActiveAlert_SystemShutdown.Text = "Begin System Shutdown, " + hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );

        }

        private void Button2_Click( object sender, EventArgs e ) {

            RandomizeHostAttributes();

        }

        private void RandomizeHostAttributes() {

            string systemdifficulty = Element_SystemDifficulty.Text;
            string systemsecuritycode = Element_SystemSecurityCode.Text;
            int securityratingvalue = Convert.ToInt32( Element_SecurityRatingValue.Value );

            Element_SecurityRatingValue.Value = hostgen.Generate_SecurityRatingValue( systemdifficulty );

            Element_SubsystemRating_Access.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Control.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Index.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Files.Value = hostgen.Generate_SubsystemRating( systemdifficulty );
            Element_SubsystemRating_Slave.Value = hostgen.Generate_SubsystemRating( systemdifficulty );


        }

        private void Button3_Click( object sender, EventArgs e ) {

            RandomizePaydata();

        }

        private void RandomizePaydata() {

            string systemdifficulty = Element_SystemDifficulty.Text;
            string systemsecuritycode = Element_SystemSecurityCode.Text;
            int securityratingvalue = Convert.ToInt32( Element_SecurityRatingValue.Value );

            Element_Paydata_Points.Value = hostgen.Generate_PaydataPoints( systemsecuritycode );
            Element_Paydata_Size.Value = hostgen.Generate_PaydataSize( systemsecuritycode );
            Element_Paydata_Defense.Text = hostgen.Generate_PaydataDefense( systemsecuritycode, securityratingvalue );

        }

        private void RandomizeNastySurprise() {

            string systemdifficulty = Element_SystemDifficulty.Text;
            string systemsecuritycode = Element_SystemSecurityCode.Text;
            int securityratingvalue = Convert.ToInt32( Element_SecurityRatingValue.Value );

            Element_NastySurprise.Text = hostgen.Generate_NastySurprise( securityratingvalue );

        }

        private void Button5_Click( object sender, EventArgs e ) {

            RandomizeNastySurprise();

        }

        private void Button6_Click( object sender, EventArgs e ) {

            RandomizeTriggerStepRange();

        }

        private void RandomizeTriggerStepRange() {

            string systemdifficulty = Element_SystemDifficulty.Text;
            string systemsecuritycode = Element_SystemSecurityCode.Text;
            int securityratingvalue = Convert.ToInt32( Element_SecurityRatingValue.Value );

            Element_TriggerStepRange_1.Value = hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_2.Value = Element_TriggerStepRange_1.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_3.Value = Element_TriggerStepRange_2.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_4.Value = Element_TriggerStepRange_3.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_5.Value = Element_TriggerStepRange_4.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_6.Value = Element_TriggerStepRange_5.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_7.Value = Element_TriggerStepRange_6.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_8.Value = Element_TriggerStepRange_7.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_9.Value = Element_TriggerStepRange_8.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_10.Value = Element_TriggerStepRange_9.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_11.Value = Element_TriggerStepRange_10.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_12.Value = Element_TriggerStepRange_11.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );
            Element_TriggerStepRange_13.Value = Element_TriggerStepRange_12.Value + hostgen.Generate_TriggerStepRange( systemsecuritycode );

        }

        private void Button4_Click( object sender, EventArgs e ) {

            RandomizeSecuritySheaf();

        }

        private void RandomizeSecuritySheaf() {

            string systemdifficulty = Element_SystemDifficulty.Text;
            string systemsecuritycode = Element_SystemSecurityCode.Text;
            int securityratingvalue = Convert.ToInt32( Element_SecurityRatingValue.Value );

            Element_Event1_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event2_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event3_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event4_NoAlert.Text = hostgen.Generate_Events_NoAlert( "No Alert", securityratingvalue );
            Element_Event5_PassiveAlert.Text = "Passive Alert, " + hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event6_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event7_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event8_PassiveAlert.Text = hostgen.Generate_Events_PassiveAlert( "Passive Alert", securityratingvalue );
            Element_Event9_ActiveAlert.Text = "Active Alert, " + hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event10_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event11_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event12_ActiveAlert.Text = hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );
            Element_Event13_ActiveAlert_SystemShutdown.Text = "Begin System Shutdown, " + hostgen.Generate_Events_ActiveAlert( "Active Alert", securityratingvalue );


        }

        private void AsTextFileToolStripMenuItem_Click( object sender, EventArgs e ) {

            ExportAsTextFile();

        }

        private void ExportAsTextFile() {

            string content;

            content = "System Difficulty:" + Element_SystemDifficulty.Text
                + "\nSystem Security Code:" + Element_SystemSecurityCode.Text
                + "\n\nSecurity Rating Value:" + Element_SecurityRatingValue.Text
                + "\n\nAccess:" + Element_SubsystemRating_Access.Text
                + "\nControl:" + Element_SubsystemRating_Control.Text
                + "\nIndex:" + Element_SubsystemRating_Index.Text
                + "\nFiles:" + Element_SubsystemRating_Files.Text
                + "\nSlave:" + Element_SubsystemRating_Slave.Text
                + "\nPaydata Points:" + Element_Paydata_Points.Value
                + "\nPaydata Size:" + Element_Paydata_Size.Value
                + "\nPaydata Defense:" + Element_Paydata_Defense.Text
                + "\n\nNasty Surprise:" + Element_NastySurprise.Text
                + "\n\nSecurity Sheaf:"
                + "\nStep\tEvent"
                + "\n==========="
                + "\n" + Element_TriggerStepRange_1.Value + ":" + Element_Event1_NoAlert.Text
                + "\n" + Element_TriggerStepRange_2.Value + ":" + Element_Event2_NoAlert.Text
                + "\n" + Element_TriggerStepRange_3.Value + ":" + Element_Event3_NoAlert.Text
                + "\n" + Element_TriggerStepRange_4.Value + ":" + Element_Event4_NoAlert.Text
                + "\n" + Element_TriggerStepRange_5.Value + ":" + Element_Event5_PassiveAlert.Text
                + "\n" + Element_TriggerStepRange_6.Value + ":" + Element_Event6_PassiveAlert.Text
                + "\n" + Element_TriggerStepRange_7.Value + ":" + Element_Event7_PassiveAlert.Text
                + "\n" + Element_TriggerStepRange_8.Value + ":" + Element_Event8_PassiveAlert.Text
                + "\n" + Element_TriggerStepRange_9.Value + ":" + Element_Event9_ActiveAlert.Text
                + "\n" + Element_TriggerStepRange_10.Value + ":" + Element_Event10_ActiveAlert.Text
                + "\n" + Element_TriggerStepRange_11.Value + ":" + Element_Event11_ActiveAlert.Text
                + "\n" + Element_TriggerStepRange_12.Value + ":" + Element_Event12_ActiveAlert.Text
                + "\n" + Element_TriggerStepRange_13.Value + ":" + Element_Event13_ActiveAlert_SystemShutdown.Text;


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK) {

                System.IO.File.WriteAllText( saveFileDialog1.FileName, content );

            }

        }

        private void ToClipboardToolStripMenuItem_Click( object sender, EventArgs e ) {

            string content;

            content = "System Difficulty:" + Element_SystemDifficulty.Text
                + "\nSystem Security Code:" + Element_SystemSecurityCode.Text
                + "\n\nSecurity Rating Value:" + Element_SecurityRatingValue.Text
                + "\n\nAccess:" + Element_SubsystemRating_Access.Text
                + "\nControl:" + Element_SubsystemRating_Control.Text
                + "\nIndex:" + Element_SubsystemRating_Index.Text
                + "\nFiles:" + Element_SubsystemRating_Files.Text
                + "\nSlave:" + Element_SubsystemRating_Slave.Text
                + "\nPaydata Points:" + Element_Paydata_Points.Value
                + "\nPaydata Size:" + Element_Paydata_Size.Value
                + "\nPaydata Defense:" + Element_Paydata_Defense.Text
                + "\n\nNasty Surprise:" + Element_NastySurprise.Text
                + "\n\nSecurity Sheaf:"
                + "\nStep\tEvent"
                + "\n==========="
                + "\n" + Element_TriggerStepRange_1.Value + ":" + Element_Event1_NoAlert.Text
                + "\n" + Element_TriggerStepRange_2.Value + ":" + Element_Event2_NoAlert.Text
                + "\n" + Element_TriggerStepRange_3.Value + ":" + Element_Event3_NoAlert.Text
                + "\n" + Element_TriggerStepRange_4.Value + ":" + Element_Event4_NoAlert.Text
                + "\n" + Element_TriggerStepRange_5.Value + ":" + Element_Event5_PassiveAlert.Text
                + "\n" + Element_TriggerStepRange_6.Value + ":" + Element_Event6_PassiveAlert.Text
                + "\n" + Element_TriggerStepRange_7.Value + ":" + Element_Event7_PassiveAlert.Text
                + "\n" + Element_TriggerStepRange_8.Value + ":" + Element_Event8_PassiveAlert.Text
                + "\n" + Element_TriggerStepRange_9.Value + ":" + Element_Event9_ActiveAlert.Text
                + "\n" + Element_TriggerStepRange_10.Value + ":" + Element_Event10_ActiveAlert.Text
                + "\n" + Element_TriggerStepRange_11.Value + ":" + Element_Event11_ActiveAlert.Text
                + "\n" + Element_TriggerStepRange_12.Value + ":" + Element_Event12_ActiveAlert.Text
                + "\n" + Element_TriggerStepRange_13.Value + ":" + Element_Event13_ActiveAlert_SystemShutdown.Text;

            Clipboard.SetText( content );

        }
    }

}
