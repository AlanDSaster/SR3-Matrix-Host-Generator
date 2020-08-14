using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun_Matrix_Host_Generator {
    
    class HostGenerator {

        private static Random RNG;

        public HostGenerator() {
            
            RNG = new Random();

        }

        public int Roll1D2() {

            return RNG.Next( 1, 3 );
            
        }

        public int Roll1D3() {

            return RNG.Next(1,4);
            
        }

        public int Roll1D6() {

            return RNG.Next( 1, 7 );

        }

        public int Generate_TriggerStepRange( string systemsecuritycode ) {

            int result = -1;

            switch(systemsecuritycode) {

                case "Blue":
                    result = Roll1D3() + 4;
                    break;

                case "Green":
                    result = Roll1D3() + 3;
                    break;

                case "Orange":
                    result = Roll1D3() + 2;
                    break;

                case "Red":
                    result = Roll1D3() + 1;
                    break;

            }

            return result;

        }

        public int Generate_SecurityRatingValue(string systemdifficulty ) {
            
            int result = -1;

            switch(systemdifficulty) {

                case "Easy":
                    result = Roll1D3() + 3;
                    break;

                case "Normal":
                    result = Roll1D3() + 6;
                    break;

                case "Hard":
                    result = Roll1D3() + Roll1D3() + 6;
                    break;

            }

            return result;

        }

        public int Generate_SubsystemRating(string systemdifficulty) {

            int result = -1;

            switch(systemdifficulty) {

                case "Easy":
                    result = Roll1D3() + 7;
                    break;

                case "Normal":
                    result = Roll1D3() + Roll1D3() + 9;
                    break;

                case "Hard":
                    result = Roll1D6() + 12;
                    break;

            }

            return result;

        }

        public int Generate_PaydataPoints( string systemsecuritycode ) {

            int result = -1;

            switch(systemsecuritycode) {

                case "Blue":
                    result = Roll1D6() - 1;
                    break;

                case "Green":
                    result = Roll1D6() + Roll1D6() - 2;
                    break;

                case "Orange":
                    result = Roll1D6() + Roll1D6();
                    break;

                case "Red":
                    result = Roll1D6() + Roll1D6() + 2;
                    break;

            }

            return result;

        }

        public int Generate_PaydataSize( string systemsecuritycode ) {

            int result = -1;

            switch(systemsecuritycode) {

                case "Blue":
                    result = Roll1D6() + Roll1D6();
                    result = result * 20;
                    break;

                case "Green":
                    result = Roll1D6() + Roll1D6();
                    result = result * 15;
                    break;

                case "Orange":
                    result = Roll1D6() + Roll1D6();
                    result = result * 10;
                    break;

                case "Red":
                    result = Roll1D6() + Roll1D6();
                    result = result * 5;
                    break;

            }

            return result;

        }

        public string Generate_PaydataDefense( string systemsecuritycode, int securityratingvalue ) {

            string result = "";

            switch(systemsecuritycode) {

                case "Blue":

                    switch(Roll1D6()) {

                        case int n when( n >= 1 && n <= 4 ):
                            result = "No Defense";
                            break;

                        case int n when( n >= 5 && n <= 6 ):
                            result = "Scramble-" + Generate_ICRating( securityratingvalue );
                            break;

                    }

                    break;

                case "Green":

                    switch(Roll1D6()) {

                        case int n when( n >= 1 && n <= 2 ):
                            result = "No Defense";
                            break;

                        case int n when( n >= 3 && n <= 6 ):
                            result = "Scramble-" + Generate_ICRating( securityratingvalue );
                            break;

                    }

                    break;

                case "Orange":

                    switch(Roll1D6()) {

                        case int n when( n >= 1 && n <= 1 ):
                            result = "No Defense";
                            break;

                        case int n when( n >= 2 && n <= 3 ):
                            result = "Scramble-" + Generate_ICRating( securityratingvalue );
                            break;

                        case int n when( n >= 4 && n <= 5 ):

                            result = Generate_DataBomb();

                            break;

                        case int n when( n >= 6 && n <= 6 ):
                            result = Generate_Worm();
                            break;

                    }

                    break;

                case "Red":

                    switch(Roll1D6()) {

                        case int n when( n >= 1 && n <= 2 ):
                            result = "Scramble-" + Generate_ICRating( securityratingvalue );
                            break;

                        case int n when( n >= 3 && n <= 4 ):

                            result = Generate_DataBomb();

                            break;

                        case int n when( n >= 5 && n <= 6 ):
                            result = Generate_Worm();
                            break;

                    }

                    break;
            }

            return result;

        }

        public string Generate_NastySurprise(int securityratingvalue) {

            string result = "";

            string target = "";

            int diceroll = Roll1D6() + Roll1D6();

            int seconddiceroll = -1;

            switch(diceroll) {

                case 2:
                    result = "Semi-Autonomous Knowbot";
                    break;

                case 3:
                    result = "Teleporting SAN";
                    break;

                case 4:
                    result = "Vanishing SAN";
                    break;

                case 5:
                    result = "Bouncer Host";
                    break;

                case 6:

                    seconddiceroll = Roll1D6();
                    
                    switch(seconddiceroll) {

                        case int z when ( z >= 1 && z <= 4 ):
                            target = " guarding a file";
                            break;

                        case int z when (z >= 5 && z <= 6 ):
                            target = " guarding a slave device";
                            break;
                    }
                    result = Generate_DataBomb() + target;

                    break;

                case 7:

                    seconddiceroll = Roll1D6();

                    switch(seconddiceroll) {

                        case int z when( z >= 1 && z <= 2 ):
                            target = " guarding Access subsystem";
                            break;

                        case int z when( z >= 3 && z <= 4 ):
                            target = " guarding Files subsystem";
                            break;

                        case int z when( z >= 5 && z <= 6 ):
                            target = " guarding Slave subsystem";
                            break;

                    }

                    result = "Scramble-" + Generate_ICRating( securityratingvalue ) + target;

                    break;

                case 8:
                    result = "Security Decker(s)";
                    break;

                case 9:
                    result = Generate_Worm();
                    break;

                case 10:
                    result = "Chokepoint";
                    break;

                case 11:
                    result = "Trap Door";
                    break;

                case 12:
                    result = "Virtual Host";
                    break;

            }

            return result;

        }

        public string Generate_Events_NoAlert(string alert, int securityratingvalue ) {

            string result = "";

            int diceroll = Roll1D6();

            switch(diceroll) {

                case int n when( n >= 1 && n <= 3 ):
                    result = Generate_ReactiveWhiteIC(securityratingvalue);
                    break;

                case int n when( n >= 4 && n <= 5 ):
                    result = Generate_ProactiveWhiteIC(alert, securityratingvalue );
                    break;

                case int n when( n >= 6 && n <= 6 ):
                    result = Generate_ReactiveGrayIC(alert, securityratingvalue );
                    break;

            }

            return result;

        }

        public string Generate_Events_PassiveAlert(string alert, int securityratingvalue) {

            string result = "";

            int diceroll = Roll1D6();

            switch(diceroll) {

                case int n when( n >= 1 && n <= 3 ):
                    result = Generate_ProactiveWhiteIC(alert, securityratingvalue);
                    break;

                case int n when( n >= 4 && n <= 5 ):
                    result = Generate_ReactiveGrayIC( alert, securityratingvalue );
                    break;

                case int n when( n >= 6 && n <= 6 ):
                    result = Generate_ProactiveGrayIC( alert, securityratingvalue );
                    break;

            }

            return result;

        }

        public string Generate_Events_ActiveAlert(string alert, int securityratingvalue) {

            string result = "";

            int diceroll = Roll1D6();

            switch(diceroll) {

                case int n when( n >= 1 && n <= 3 ):
                    result = Generate_ProactiveGrayIC( alert, securityratingvalue );
                    break;

                case int n when( n >= 4 && n <= 5 ):
                    result = Generate_ProactiveWhiteIC( alert, securityratingvalue );
                    break;

                case int n when( n >= 6 && n <= 6 ):
                    result = Generate_BlackIC(alert, securityratingvalue);
                    break;

            }

            return result;

        }

        public string Generate_ReactiveWhiteIC(int securityratingvalue ) {

            string result = "";

            int diceroll = Roll1D6();

            switch(diceroll) {

                case int n when( n >= 1 && n <= 2 ):
                    result = "Probe-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 3 && n <= 5 ):
                    result = "Trace-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 6 && n <= 6 ):
                    result = "Tar Baby-" + Generate_ICRating( securityratingvalue );
                    break;
            }

            return result;

        }

        public string Generate_ProactiveWhiteIC(string alert, int securityratingvalue ) {

            string result = "";

            int diceroll = Roll1D6() + Roll1D6();

            switch(diceroll) {

                case int n when( n >= 2 && n <= 5 ):
                    result = Generate_CripplerIC( securityratingvalue );
                    break;

                case int n when( n >= 6 && n <= 8 ):
                    result = "Killer-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 9 && n <= 11 ):
                    result = "Scout-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 12 && n <= 12 ):
                    result = Generate_Construct(alert, securityratingvalue);
                    break;
            }

            return result;

        }

        public string Generate_ReactiveGrayIC(string alert, int securityratingvalue ) {

            string result = "";

            string trapoption = "";

            int diceroll = Roll1D6();

            switch(diceroll) {

                case int n when( n >= 1 && n <= 2 ):
                    result = "Tar Pit-" + Generate_ICRating( securityratingvalue );
                    break;

                case 3:
                    trapoption = Generate_TrapOption( alert, securityratingvalue );
                    result = "Trace-" + Generate_ICRating(securityratingvalue) + trapoption;
                    break;

                case 4:
                    trapoption = Generate_TrapOption( alert, securityratingvalue );
                    result = "Probe-" + Generate_ICRating( securityratingvalue ) + trapoption;
                    break;

                case 5:
                    trapoption = Generate_TrapOption( alert, securityratingvalue );
                    result = "Scout-" + Generate_ICRating( securityratingvalue ) + trapoption;
                    break;

                case 6:
                    result = Generate_Construct( alert, securityratingvalue );
                    break;
            }

            return result;

        }

        public string Generate_ProactiveGrayIC(string alert, int securityratingvalue ) {

            string result = "";

            int diceroll = Roll1D6() + Roll1D6();

            switch(diceroll) {

                case int n when( n >= 2 && n <= 5 ):
                    result = Generate_RipperIC(securityratingvalue);
                    break;

                case int n when( n >= 6 && n <= 8 ):
                    result = "Blaster-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 9 && n <= 11 ):
                    result = "Sparky-" + Generate_ICRating( securityratingvalue );
                    break;

                case 12:
                    result = Generate_Construct( alert, securityratingvalue );
                    break;

            }

            return result;

        }

        public string Generate_BlackIC(string alert, int securityratingvalue ) {

            string result = "";

            string base_IC = "";

            string type = "";

            string subtype = "";

            int diceroll = Roll1D6() + Roll1D6();

            int secondarydiceroll = -1;

            base_IC = "Black IC-" + Generate_ICRating( securityratingvalue );
            
            switch(diceroll) {

                case int n when( n >= 2 && n <= 4 ):

                    secondarydiceroll = Roll1D6();

                    switch(secondarydiceroll) {

                        case int x when( x >= 1 && x <= 2 ):
                            subtype = "Cyberphobia";
                            break;

                        case 3:
                            subtype = "Frenzy";
                            break;

                        case 4:
                            subtype = "Judas";
                            break;

                        case int x when( x >= 5 && x <= 6 ):
                            subtype = "Positive Conditioning";
                            break;
                        
                    }

                    type = " (Psychotropic: " + subtype + ")";
                    break;

                case int n when( n >= 5 && n <= 7 ):
                    type = " (Lethal)";
                    break;

                case int n when( n >= 8 && n <= 10 ):
                    type = " (Non-Lethal)";
                    break;

                case 11:
                    type = " (Cerebropathic)";
                    break;

                case 12:
                    type = " (" + Generate_Construct( alert, securityratingvalue ) + ")";
                    break;

            }

            result = base_IC + type;

            return result;

        }

        public string Generate_TrapOption(string alert, int securityratingvalue ) {

            string result = "";

            int diceroll = Roll1D6() + Roll1D6();

            switch(diceroll) {

                case 2:
                    result = Generate_DataBomb();
                    break;

                case int n when( n >= 3 && n <= 5 ):
                    result = "Blaster-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 6 && n <= 8 ):
                    result = "Killer-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 9 && n <= 11 ):
                    result = "Sparky-" + Generate_ICRating( securityratingvalue );
                    break;

                case 12:
                    result = Generate_BlackIC(alert, securityratingvalue);
                    break;

            }

            result = " with trap option (" + result + ")";

            return result;

        }

        public string Generate_Construct( string alert, int securityratingvalue) {
            
            int framecorerating = Generate_ICRating( securityratingvalue ) * 2;

            int ic_capacity = framecorerating * 2;

            int TotalICRating = 0;

            int ICRating = 0;

            string ContainedIC = "";

            string result = "";


            while( TotalICRating < ic_capacity) {

                //IC_2 = Generate_Events_ActiveAlert();

                switch(alert) {

                    case "No Alert":

                        ICRating = Generate_ICRating(securityratingvalue);

                        if(ICRating + TotalICRating > ic_capacity ) {

                            ICRating = ic_capacity - TotalICRating;

                        }

                        TotalICRating = TotalICRating + ICRating;

                        ContainedIC = ContainedIC + ", " + Generate_Events_NoAlert( alert, securityratingvalue );

                        break;

                    case "Passive Alert":

                        ICRating = Generate_ICRating( securityratingvalue );

                        if((ICRating + TotalICRating) > ic_capacity) {

                            ICRating = ic_capacity - TotalICRating;

                        }

                        TotalICRating = TotalICRating + ICRating;

                        ContainedIC = ContainedIC + ", " + Generate_Events_PassiveAlert( alert, securityratingvalue );

                        break;

                    case "Active Alert":
                        ICRating = Generate_ICRating( securityratingvalue );

                        if(ICRating + TotalICRating > ic_capacity) {

                            ICRating = framecorerating - TotalICRating;

                        }

                        TotalICRating = TotalICRating + ICRating;

                        ContainedIC = ContainedIC + ", " + Generate_Events_ActiveAlert( alert, securityratingvalue );

                        break;
                        
                }

            }

            ContainedIC = ContainedIC.Substring( 2 );

            result = "Construct-" + framecorerating + " (" + ContainedIC + ")";

            return result;

        }

        public string Generate_CripplerIC(int securityratingvalue) {

            string result = "";

            int diceroll = Roll1D6();

            switch(diceroll) {

                case int n when( n >= 1 && n <= 2 ):
                    result = "Crippler(Bod)-" + Generate_ICRating(securityratingvalue);
                    break;

                case int n when( n >= 3 && n <= 3 ):
                    result = "Crippler(Evasion)-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 4 && n <= 5 ):
                    result = "Crippler(Masking)-" + Generate_ICRating( securityratingvalue );
                    break;
                
                case int n when( n >= 6 && n <= 6 ):
                    result = "Crippler(Sensor)-" + Generate_ICRating( securityratingvalue );
                    break;

            }

            return result;

        }

        public string Generate_RipperIC( int securityratingvalue ) {

            string result = "";

            int diceroll = Roll1D6();

            switch(diceroll) {

                case int n when( n >= 1 && n <= 2 ):
                    result = "Ripper(Bod)-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 3 && n <= 3 ):
                    result = "Ripper(Evasion)-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 4 && n <= 5 ):
                    result = "Ripper(Masking)-" + Generate_ICRating( securityratingvalue );
                    break;

                case int n when( n >= 6 && n <= 6 ):
                    result = "Ripper(Sensor)-" + Generate_ICRating( securityratingvalue );
                    break;

            }

            return result;

        }

        public int Generate_ICRating( int securityratingvalue ) {

            int diceroll = Roll1D6() + Roll1D6();

            int result = -1;

            switch(securityratingvalue) {

                case int x when( x >= 1 && x <= 4 ):

                    switch(diceroll) {

                        case int n when( n >= 1 && n <= 5 ):

                            result = 4;
                            break;

                        case int n when( n >= 6 && n <= 8 ):
                            result = 5;
                            break;

                        case int n when( n >= 9 && n <= 11 ):
                            result = 6;
                            break;

                        case int n when( n == 12 ):
                            result = 7;
                            break;
                    }

                    break;

                case int x when( x >= 5 && x <= 7 ):

                    switch(diceroll) {

                        case int n when( n >= 1 && n <= 5 ):

                            result = 5;
                            break;

                        case int n when( n >= 6 && n <= 8 ):
                            result = 7;
                            break;

                        case int n when( n >= 9 && n <= 11 ):
                            result = 9;
                            break;

                        case 12:
                            result = 10;
                            break;
                    }

                    break;

                case int x when( x >= 8 && x <= 10 ):

                    switch(diceroll) {

                        case int n when( n >= 1 && n <= 5 ):

                            result = 6;
                            break;

                        case int n when( n >= 6 && n <= 8 ):
                            result = 8;
                            break;

                        case int n when( n >= 9 && n <= 11 ):
                            result = 10;
                            break;

                        case int n when( n == 12 ):
                            result = 12;
                            break;
                    }

                    break;

                case int x when( x >= 11 && x <= 12 ):

                    switch(diceroll) {

                        case int n when( n >= 1 && n <= 5 ):

                            result = 8;
                            break;

                        case int n when( n >= 6 && n <= 8 ):
                            result = 10;
                            break;

                        case int n when( n >= 9 && n <= 11 ):
                            result = 11;
                            break;

                        case int n when( n == 12 ):
                            result = 12;
                            break;
                    }

                    break;

            }            

            return result;

        }
        
        public string Generate_DataBomb() {

            string result = "";

            switch(Roll1D6()) {

                case int x when( x >= 1 && x <= 4 ):
                    result = "Standard Data Bomb IC";
                    break;

                case int x when( x >= 5 && x <= 6 ):
                    result = "Pavlov IC";
                    break;

            }

            return result;

        }

        public string Generate_Worm() {

            string result = "";

            switch(Roll1D6() + Roll1D6()) {

                case int x when( x >= 2 && x <= 3 ):
                    result = "Crashworm-" + (Roll1D3()+3);
                    break;

                case int x when( x >= 4 && x <= 5 ):
                    result = "Deathworm-" + ( Roll1D3() + 3 );
                    break;

                case int x when( x >= 6 && x <= 8 ):
                    result = "Dataworm-" + ( Roll1D3() + 3 );
                    break;

                case int x when( x >= 9 && x <= 10 ):
                    result = "Tapeworm-" + ( Roll1D3() + 3 );
                    break;

                case int x when( x >= 11 && x <= 12 ):
                    result = "Ringworm-" + ( Roll1D3() + 3 );
                    break;

            }

            return result;

        }

    }

}
