using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpssLib.SpssDataset;
using SpssLib.DataReader;
using System.IO;

namespace Radar_parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int SurveyID = 600638;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2019-03-31";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_radar iobj = new DB_insertion_radar();
            string questions = "CN,weight,SEC,BAREA,GEN,S3a,D1,D4,D3,WAVE,B1,B2_1,B2_11,B2_12,B2_13,B2_25,B2_26,B2_29,B2_45,B2_47,B2_51,B2_54,B2_80,B2_81,B1B2B4_1,B1B2B4_11,B1B2B4_12,B1B2B4_13,B1B2B4_25,B1B2B4_26,B1B2B4_29,B1B2B4_45,B1B2B4_47,B1B2B4_51,B1B2B4_54,B1B2B4_80,B1B2B4_81,B3_TOM,B3_TOTAL_1,B3_TOTAL_11,B3_TOTAL_12,B3_TOTAL_13,B3_TOTAL_25,B3_TOTAL_26,B3_TOTAL_29,B3_TOTAL_45,B3_TOTAL_47,B3_TOTAL_51,B3_TOTAL_54,B3_TOTAL_80,B3_TOTAL_81,B3B5_1,B3B5_11,B3B5_12,B3B5_13,B3B5_25,B3B5_26,B3B5_29,B3B5_45,B3B5_47,B3B5_51,B3B5_54,B3B5_80,B3B5_81,B9,B11,B12,B14,B6_B6_1_1,B6_B6_1_11,B6_B6_1_12,B6_B6_1_13,B6_B6_1_25,B6_B6_1_26,B6_B6_1_29,B6_B6_1_45,B6_B6_1_47,B6_B6_1_51,B6_B6_1_54,B6_B6_1_80,B6_B6_1_81,B6_B6_81_1,B8_1,B8_11,B8_12,B8_13,B8_25,B8_26,B8_29,B8_45,B8_47,B8_51,B8_54,B8_80,B8_81,B7_1,B7_11,B7_12,B7_13,B7_25,B7_26,B7_29,B7_45,B7_47,B7_51,B7_54,B7_80,B7_81,B1_NET,B2_NET_5001,B2_NET_5006,B2_NET_5007,B2_NET_5011,B2_NET_5014,B1B2B4_NET_5001,B1B2B4_NET_5006,B1B2B4_NET_5007,B1B2B4_NET_5011,B1B2B4_NET_5014,B3_TOM_NET,B3TOM_B3OM_NET_5001,B3TOM_B3OM_NET_5006,B3TOM_B3OM_NET_5007,B3TOM_B3OM_NET_5011,B3TOM_B3OM_NET_5014,B3TOM_B3OM_B5_NET_5001,B3TOM_B3OM_B5_NET_5006,B3TOM_B3OM_B5_NET_5007,B3TOM_B3OM_B5_NET_5011,B3TOM_B3OM_B5_NET_5014,B6B6_1_NET_5001,B6B6_1_NET_5006,B6B6_1_NET_5007,B6B6_1_NET_5011,B6B6_1_NET_5014,B8_NET_5001,B8_NET_5006,B8_NET_5007,B8_NET_5011,B8_NET_5014,B9_NET,B12_NET,B11_NET,B14_NET,GRID_B15_NET_1_B15_NET_5001,GRID_B15_NET_1_B15_NET_5006,GRID_B15_NET_1_B15_NET_5007,GRID_B15_NET_1_B15_NET_5011,GRID_B15_NET_1_B15_NET_5014,GRID_B7_NET_1_B7_NET_5001,GRID_B7_NET_1_B7_NET_5006,GRID_B7_NET_1_B7_NET_5007,GRID_B7_NET_1_B7_NET_5011,S5_1,S5_2,S5_3,S5_4,S5_5,S5_6,S5_7,S5_8,S5_9,S6_1,S6_2,S6_3,S6_4,S6_5,S6_6,S6_7,S6_8,S6_9,S7_1,S7_2,S7_3,S7_4,S7_5,S7_6,S7_7,S7_8,S7_9,S8_1,S8_2,S8_3,S8_4,S8_5,S8_6,S8_7,S8_8,S8_9,S8_1_1,S8_1_2,S8_1_3,S8_1_4,S8_1_5,S8_1_6,S8_1_7,S8_1_8,S8_1_9,Grid_I3n_1_I3n03,Grid_I3n_1_I3n04,Grid_I3n_1_I3n05,Grid_I3n_1_I3n08,Grid_I3n_1_I3n12,Grid_I3n_1_I3n13,Grid_I3n_1_I3n17,Grid_I3n_1_I3n18,Grid_I3n_1_I3n19,Grid_I3n_1_I3n20,Grid_I3n_81_I3n03,Grid_I3n_81_I3n04,Grid_I3n_81_I3n05,Grid_I3n_81_I3n08,Grid_I3n_81_I3n12,Grid_I3n_81_I3n13,Grid_I3n_81_I3n17,Grid_I3n_81_I3n18,Grid_I3n_81_I3n19,Grid_I3n_81_I3n20,Grid_I3n_54_I3n03,Grid_I3n_54_I3n04,Grid_I3n_54_I3n05,Grid_I3n_54_I3n08,Grid_I3n_54_I3n12,Grid_I3n_54_I3n13,Grid_I3n_54_I3n17,Grid_I3n_54_I3n18,Grid_I3n_54_I3n19,Grid_I3n_54_I3n20,Grid_I3n_11_I3n03,Grid_I3n_11_I3n04,Grid_I3n_11_I3n05,Grid_I3n_11_I3n08,Grid_I3n_11_I3n12,Grid_I3n_11_I3n13,Grid_I3n_11_I3n17,Grid_I3n_11_I3n18,Grid_I3n_11_I3n19,Grid_I3n_11_I3n20,Grid_I3n_12_I3n03,Grid_I3n_12_I3n04,Grid_I3n_12_I3n05,Grid_I3n_12_I3n08,Grid_I3n_12_I3n12,Grid_I3n_12_I3n13,Grid_I3n_12_I3n17,Grid_I3n_12_I3n18,Grid_I3n_12_I3n19,Grid_I3n_12_I3n20,Grid_I3n_25_I3n03,Grid_I3n_25_I3n04,Grid_I3n_25_I3n05,Grid_I3n_25_I3n08,Grid_I3n_25_I3n12,Grid_I3n_25_I3n13,Grid_I3n_25_I3n17,Grid_I3n_25_I3n18,Grid_I3n_25_I3n19,Grid_I3n_25_I3n20,Grid_I3n_26_I3n03,Grid_I3n_26_I3n04,Grid_I3n_26_I3n05,Grid_I3n_26_I3n08,Grid_I3n_26_I3n12,Grid_I3n_26_I3n13,Grid_I3n_26_I3n17,Grid_I3n_26_I3n18,Grid_I3n_26_I3n19,Grid_I3n_26_I3n20,Grid_I3n_29_I3n03,Grid_I3n_29_I3n04,Grid_I3n_29_I3n05,Grid_I3n_29_I3n08,Grid_I3n_29_I3n12,Grid_I3n_29_I3n13,Grid_I3n_29_I3n17,Grid_I3n_29_I3n18,Grid_I3n_29_I3n19,Grid_I3n_29_I3n20,Grid_I3n_47_I3n03,Grid_I3n_47_I3n04,Grid_I3n_47_I3n05,Grid_I3n_47_I3n08,Grid_I3n_47_I3n12,Grid_I3n_47_I3n13,Grid_I3n_47_I3n17,Grid_I3n_47_I3n18,Grid_I3n_47_I3n19,Grid_I3n_47_I3n20,Grid_I3n_51_I3n03,Grid_I3n_51_I3n04,Grid_I3n_51_I3n05,Grid_I3n_51_I3n08,Grid_I3n_51_I3n12,Grid_I3n_51_I3n13,Grid_I3n_51_I3n17,Grid_I3n_51_I3n18,Grid_I3n_51_I3n19,Grid_I3n_51_I3n20";// dashboard variable value                
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\Radar\RADAR_Full_W2_v7.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            {
                spssDataset = new SpssReader(fileStream); // Create the reader, this will read the file header
                foreach (string spss_v in spss_variable_name)
                {
                    foreach (var variable in spssDataset.Variables)  // Iterate through all the varaibles
                    {
                        if (variable.Name.Equals(spss_v))
                        {
                            foreach (KeyValuePair<double, string> label in variable.ValueLabels)
                            {
                                string VARIABLE_NAME = spss_v;
                                string VARIABLE_NAME_SUB_NAME = variable.Name;
                                string VARIABLE_ID = label.Key.ToString();
                                string VARIABLE_VALUE = label.Value;
                                string VARIABLE_NAME_QUESTION = variable.Label;
                                string BASE_VARIABLE_NAME = variable.Name;
                               // iobj.insert_Dashboard_variable_values(VARIABLE_NAME, VARIABLE_NAME_SUB_NAME, VARIABLE_ID, VARIABLE_VALUE, VARIABLE_NAME_QUESTION, SurveyID, country, BASE_VARIABLE_NAME, AttendedOn);
                            }
                        }

                    }
                }
                foreach (var record in spssDataset.Records)
                {
                    string userID = null;
                    string u_id = null;
                    string variable_name;
                    decimal Weight = 1;

                    string Country = "-- Not Available --";
                    string SES = "-- Not Available --";
                    string Location = "-- Not Available --";
                    string AgeGroup = "-- Not Available --";
                    string Gender = "-- Not Available --";
                    string MaritalStatus = "-- Not Available --";
                    string Occupation = "-- Not Available --";
                    string Education = "-- Not Available --";
                    string period = "-- Not Available --";
                    string BrTom = "-- Not Available --";
                    string BrSpont_Absolute_Distilled_W = "-- Not Available --";
                    string BrSpont_Nature_Spring_Alkaline_DW = "-- Not Available --";
                    string BrSpont_Nature_Spring_Distilled_DW = "-- Not Available --";
                    string BrSpont_Nature_Spring_Purified_DW = "-- Not Available --";
                    string BrSpont_Refresh_Mineral_W = "-- Not Available --";
                    string BrSpont_Refresh_Purified_W = "-- Not Available --";
                    string BrSpont_Summit_Spring_W = "-- Not Available --";
                    string BrSpont_Wet_Water_Mineral_W = "-- Not Available --";
                    string BrSpont_Wilkins_Distilled_W = "-- Not Available --";
                    string BrSpont_Wilkins_Pure_Water_Purified_W = "-- Not Available --";
                    string BrSpont_LE_MINERALE = "-- Not Available --";
                    string BrSpont_Sip_Purified_W = "-- Not Available --";
                    string BrSpont_Aquafina_Purified_W = "-- Not Available --";
                    string BrAided_Absolute_Distilled_W = "-- Not Available --";
                    string BrAided_Nature_Spring_Alkaline_DW = "-- Not Available --";
                    string BrAided_Nature_Spring_Distilled_DW = "-- Not Available --";
                    string BrAided_Nature_Spring_Purified_DW = "-- Not Available --";
                    string BrAided_Refresh_Mineral_W = "-- Not Available --";
                    string BrAided_Refresh_Purified_W = "-- Not Available --";
                    string BrAided_Summit_Spring_W = "-- Not Available --";
                    string BrAided_Wet_Water_Mineral_W = "-- Not Available --";
                    string BrAided_Wilkins_Distilled_W = "-- Not Available --";
                    string BrAided_Wilkins_Pure_Water_Purified_W = "-- Not Available --";
                    string BrAided_LE_MINERALE = "-- Not Available --";
                    string BrAided_Sip_Purified_W = "-- Not Available --";
                    string BrAided_Aquafina_Purified_W = "-- Not Available --";
                    string AdTom = "-- Not Available --";
                    string AdSpont_Absolute_Distilled_W = "-- Not Available --";
                    string AdSpont_Nature_Spring_Alkaline_DW = "-- Not Available --";
                    string AdSpont_Nature_Spring_Distilled_DW = "-- Not Available --";
                    string AdSpont_Nature_Spring_Purified_DW = "-- Not Available --";
                    string AdSpont_Refresh_Mineral_W = "-- Not Available --";
                    string AdSpont_Refresh_Purified_W = "-- Not Available --";
                    string AdSpont_Summit_Spring_W = "-- Not Available --";
                    string AdSpont_Wet_Water_Mineral_W = "-- Not Available --";
                    string AdSpont_Wilkins_Distilled_W = "-- Not Available --";
                    string AdSpont_Wilkins_Pure_Water_Purified_W = "-- Not Available --";
                    string AdSpont_LE_MINERALE = "-- Not Available --";
                    string AdSpont_Sip_Purified_W = "-- Not Available --";
                    string AdSpont_Aquafina_Purified_W = "-- Not Available --";
                    string AdAided_Absolute_Distilled_W = "-- Not Available --";
                    string AdAided_Nature_Spring_Alkaline_DW = "-- Not Available --";
                    string AdAided_Nature_Spring_Distilled_DW = "-- Not Available --";
                    string AdAided_Nature_Spring_Purified_DW = "-- Not Available --";
                    string AdAided_Refresh_Mineral_W = "-- Not Available --";
                    string AdAided_Refresh_Purified_W = "-- Not Available --";
                    string AdAided_Summit_Spring_W = "-- Not Available --";
                    string AdAided_Wet_Water_Mineral_W = "-- Not Available --";
                    string AdAided_Wilkins_Distilled_W = "-- Not Available --";
                    string AdAided_Wilkins_Pure_Water_Purified_W = "-- Not Available --";
                    string AdAided_LE_MINERALE = "-- Not Available --";
                    string AdAided_Sip_Purified_W = "-- Not Available --";
                    string AdAided_Aquafina_Purified_W = "-- Not Available --";
                    string Bumo = "-- Not Available --";
                    string PerBUMO = "-- Not Available --";
                    string Favourite_Brand = "-- Not Available --";
                    string Br_LikelyToSwitch_To = "-- Not Available --";
                    string EverTried_Absolute_Distilled_W = "-- Not Available --";
                    string EverTried_Nature_Spring_Alkaline_DW = "-- Not Available --";
                    string EverTried_Nature_Spring_Distilled_DW = "-- Not Available --";
                    string EverTried_Nature_Spring_Purified_DW = "-- Not Available --";
                    string EverTried_Refresh_Mineral_W = "-- Not Available --";
                    string EverTried_Refresh_Purified_W = "-- Not Available --";
                    string EverTried_Summit_Spring_W = "-- Not Available --";
                    string EverTried_Wet_Water_Mineral_W = "-- Not Available --";
                    string EverTried_Wilkins_Distilled_W = "-- Not Available --";
                    string EverTried_Wilkins_Pure_Water_Purified_W = "-- Not Available --";
                    string EverTried_LE_MINERALE = "-- Not Available --";
                    string EverTried_Sip_Purified_W = "-- Not Available --";
                    string EverTried_Aquafina_Purified_W = "-- Not Available --";
                    string ConsP3M_Absolute_Distilled_W = "-- Not Available --";
                    string ConsP3M_Nature_Spring_Alkaline_DW = "-- Not Available --";
                    string ConsP3M_Nature_Spring_Distilled_DW = "-- Not Available --";
                    string ConsP3M_Nature_Spring_Purified_DW = "-- Not Available --";
                    string ConsP3M_Refresh_Mineral_W = "-- Not Available --";
                    string ConsP3M_Refresh_Purified_W = "-- Not Available --";
                    string ConsP3M_Summit_Spring_W = "-- Not Available --";
                    string ConsP3M_Wet_Water_Mineral_W = "-- Not Available --";
                    string ConsP3M_Wilkins_Distilled_W = "-- Not Available --";
                    string ConsP3M_Wilkins_Pure_Water_Purified_W = "-- Not Available --";
                    string ConsP3M_LE_MINERALE = "-- Not Available --";
                    string ConsP3M_Sip_Purified_W = "-- Not Available --";
                    string ConsP3M_Aquafina_Purified_W = "-- Not Available --";
                    string Br_L_Used_Absolute_Distilled_W = "-- Not Available --";
                    string Br_L_Used_Nature_Spring_Alkaline_DW = "-- Not Available --";
                    string Br_L_Used_Nature_Spring_Distilled_DW = "-- Not Available --";
                    string Br_L_Used_Nature_Spring_Purified_DW = "-- Not Available --";
                    string Br_L_Used_Refresh_Mineral_W = "-- Not Available --";
                    string Br_L_Used_Refresh_Purified_W = "-- Not Available --";
                    string Br_L_Used_Summit_Spring_W = "-- Not Available --";
                    string Br_L_Used_Wet_Water_Mineral_W = "-- Not Available --";
                    string Br_L_Used_Wilkins_Distilled_W = "-- Not Available --";
                    string Br_L_Used_Wilkins_Pure_Water_Purified_W = "-- Not Available --";
                    string Br_L_Used_LE_MINERALE = "-- Not Available --";
                    string Br_L_Used_Sip_Purified_W = "-- Not Available --";
                    string Br_L_Used_Aquafina_Purified_W = "-- Not Available --";
                    string NetBrTom = "-- Not Available --";
                    string BrSpont_ABSOLUTE_NET = "-- Not Available --";
                    string BrSpont_LE_MINERALE_NET = "-- Not Available --";
                    string BrSpont_NATURE_SPRING_NET = "-- Not Available --";
                    string BrSpont_SUMMIT_NET = "-- Not Available --";
                    string BrSpont_WILKINS_NET = "-- Not Available --";
                    string BrAided_ABSOLUTE_NET = "-- Not Available --";
                    string BrAided_LE_MINERALE_NET = "-- Not Available --";
                    string BrAided_NATURE_SPRING_NET = "-- Not Available --";
                    string BrAided_SUMMIT_NET = "-- Not Available --";
                    string BrAided_WILKINS_NET = "-- Not Available --";
                    string AdTom_NET = "-- Not Available --";
                    string AdSpont_ABSOLUTE_NET = "-- Not Available --";
                    string AdSpont_LE_MINERALE_NET = "-- Not Available --";
                    string AdSpont_NATURE_SPRING_NET = "-- Not Available --";
                    string AdSpont_SUMMIT_NET = "-- Not Available --";
                    string AdSpont_WILKINS_NET = "-- Not Available --";
                    string AdAided_ABSOLUTE_NET = "-- Not Available --";
                    string AdAided_LE_MINERALE_NET = "-- Not Available --";
                    string AdAided_NATURE_SPRING_NET = "-- Not Available --";
                    string AdAided_SUMMIT_NET = "-- Not Available --";
                    string AdAided_WILKINS_NET = "-- Not Available --";
                    string Br_Ever_tried_ABSOLUTE_NET = "-- Not Available --";
                    string Br_Ever_tried_LE_MINERALE_NET = "-- Not Available --";
                    string Br_Ever_tried_NATURE_SPRING_NET = "-- Not Available --";
                    string Br_Ever_tried_SUMMIT_NET = "-- Not Available --";
                    string Br_Ever_tried_WILKINS_NET = "-- Not Available --";
                    string REG_BR_P3M_ABSOLUTE_NET = "-- Not Available --";
                    string REG_BR_P3M_LE_MINERALE_NET = "-- Not Available --";
                    string REG_BR_P3M_NATURE_SPRING_NET = "-- Not Available --";
                    string REG_BR_P3M_SUMMIT_NET = "-- Not Available --";
                    string REG_BR_P3M_WILKINS_NET = "-- Not Available --";
                    string NetBumo = "-- Not Available --";
                    string NetFavourite_Brand = "-- Not Available --";
                    string NetPerBUMO = "-- Not Available --";
                    string NetBrLikely = "-- Not Available --";
                    string Freq_Cons_ABSOLUTE_NET = "-- Not Available --";
                    string Freq_Cons_LE_MINERALE_NET = "-- Not Available --";
                    string Freq_Cons_NATURE_SPRING_NET = "-- Not Available --";
                    string Freq_Cons_SUMMIT_NET = "-- Not Available --";
                    string Freq_Cons_WILKINS_NET = "-- Not Available --";
                    string Br_used_ABSOLUTE_NET = "-- Not Available --";
                    string Br_used_LE_MINERALE_NET = "-- Not Available --";
                    string Br_used_NATURE_SPRING_NET = "-- Not Available --";
                    string Br_used_SUMMIT_NET = "-- Not Available --";
                    string Cat_Cons_P6M_Plain_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_P6M_Flavored_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_P6M_RTD_Coffee = "-- Not Available --";
                    string Cat_Cons_P6M_Softdrinks = "-- Not Available --";
                    string Cat_Cons_P6M_Chocolate_drink = "-- Not Available --";
                    string Cat_Cons_P6M_RTD_Juices = "-- Not Available --";
                    string Cat_Cons_P6M_RTD_Iced_Tea = "-- Not Available --";
                    string Cat_Cons_P6M_Soya_Milk_unflavored = "-- Not Available --";
                    string Cat_Cons_P6M_Soya_Milk_flavored = "-- Not Available --";
                    string Cat_Cons_P3M_Plain_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_P3M_Flavored_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_P3M_RTD_Coffee = "-- Not Available --";
                    string Cat_Cons_P3M_Softdrinks = "-- Not Available --";
                    string Cat_Cons_P3M_Chocolate_drink = "-- Not Available --";
                    string Cat_Cons_P3M_RTD_Juices = "-- Not Available --";
                    string Cat_Cons_P3M_RTD_Iced_Tea = "-- Not Available --";
                    string Cat_Cons_P3M_Soya_Milk_unflavored = "-- Not Available --";
                    string Cat_Cons_P3M_Soya_Milk_flavored = "-- Not Available --";
                    string Cat_Cons_P1M_Plain_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_P1M_Flavored_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_P1M_RTD_Coffee = "-- Not Available --";
                    string Cat_Cons_P1M_Softdrinks = "-- Not Available --";
                    string Cat_Cons_P1M_Chocolate_drink = "-- Not Available --";
                    string Cat_Cons_P1M_RTD_Juices = "-- Not Available --";
                    string Cat_Cons_P1M_RTD_Iced_Tea = "-- Not Available --";
                    string Cat_Cons_P1M_Soya_Milk_unflavored = "-- Not Available --";
                    string Cat_Cons_P1M_Soya_Milk_flavored = "-- Not Available --";
                    string Cat_Cons_P1W_Plain_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_P1W_Flavored_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_P1W_RTD_Coffee = "-- Not Available --";
                    string Cat_Cons_P1W_Softdrinks = "-- Not Available --";
                    string Cat_Cons_P1W_Chocolate_drink = "-- Not Available --";
                    string Cat_Cons_P1W_RTD_Juices = "-- Not Available --";
                    string Cat_Cons_P1W_RTD_Iced_Tea = "-- Not Available --";
                    string Cat_Cons_P1W_Soya_Milk_unflavored = "-- Not Available --";
                    string Cat_Cons_P1W_Soya_Milk_flavored = "-- Not Available --";
                    string Cat_Cons_Daily_Plain_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_Daily_Flavored_Bottled_Water = "-- Not Available --";
                    string Cat_Cons_Daily_RTD_Coffee = "-- Not Available --";
                    string Cat_Cons_Daily_Softdrinks = "-- Not Available --";
                    string Cat_Cons_Daily_Chocolate_drink = "-- Not Available --";
                    string Cat_Cons_Daily_RTD_Juices = "-- Not Available --";
                    string Cat_Cons_Daily_RTD_Iced_Tea = "-- Not Available --";
                    string Cat_Cons_Daily_Soya_Milk_unflavored = "-- Not Available --";
                    string Cat_Cons_Daily_Soya_Milk_flavored = "-- Not Available --";
                    string Grid_I3n_1_I3n03 = "-- Not Available --";
                    string Grid_I3n_1_I3n04 = "-- Not Available --";
                    string Grid_I3n_1_I3n05 = "-- Not Available --";
                    string Grid_I3n_1_I3n08 = "-- Not Available --";
                    string Grid_I3n_1_I3n12 = "-- Not Available --";
                    string Grid_I3n_1_I3n13 = "-- Not Available --";
                    string Grid_I3n_1_I3n17 = "-- Not Available --";
                    string Grid_I3n_1_I3n18 = "-- Not Available --";
                    string Grid_I3n_1_I3n19 = "-- Not Available --";
                    string Grid_I3n_1_I3n20 = "-- Not Available --";
                    string Grid_I3n_81_I3n03 = "-- Not Available --";
                    string Grid_I3n_81_I3n04 = "-- Not Available --";
                    string Grid_I3n_81_I3n05 = "-- Not Available --";
                    string Grid_I3n_81_I3n08 = "-- Not Available --";
                    string Grid_I3n_81_I3n12 = "-- Not Available --";
                    string Grid_I3n_81_I3n13 = "-- Not Available --";
                    string Grid_I3n_81_I3n17 = "-- Not Available --";
                    string Grid_I3n_81_I3n18 = "-- Not Available --";
                    string Grid_I3n_81_I3n19 = "-- Not Available --";
                    string Grid_I3n_81_I3n20 = "-- Not Available --";
                    string Grid_I3n_54_I3n03 = "-- Not Available --";
                    string Grid_I3n_54_I3n04 = "-- Not Available --";
                    string Grid_I3n_54_I3n05 = "-- Not Available --";
                    string Grid_I3n_54_I3n08 = "-- Not Available --";
                    string Grid_I3n_54_I3n12 = "-- Not Available --";
                    string Grid_I3n_54_I3n13 = "-- Not Available --";
                    string Grid_I3n_54_I3n17 = "-- Not Available --";
                    string Grid_I3n_54_I3n18 = "-- Not Available --";
                    string Grid_I3n_54_I3n19 = "-- Not Available --";
                    string Grid_I3n_54_I3n20 = "-- Not Available --";
                    string Grid_I3n_11_I3n03 = "-- Not Available --";
                    string Grid_I3n_11_I3n04 = "-- Not Available --";
                    string Grid_I3n_11_I3n05 = "-- Not Available --";
                    string Grid_I3n_11_I3n08 = "-- Not Available --";
                    string Grid_I3n_11_I3n12 = "-- Not Available --";
                    string Grid_I3n_11_I3n13 = "-- Not Available --";
                    string Grid_I3n_11_I3n17 = "-- Not Available --";
                    string Grid_I3n_11_I3n18 = "-- Not Available --";
                    string Grid_I3n_11_I3n19 = "-- Not Available --";
                    string Grid_I3n_11_I3n20 = "-- Not Available --";
                    string Grid_I3n_12_I3n03 = "-- Not Available --";
                    string Grid_I3n_12_I3n04 = "-- Not Available --";
                    string Grid_I3n_12_I3n05 = "-- Not Available --";
                    string Grid_I3n_12_I3n08 = "-- Not Available --";
                    string Grid_I3n_12_I3n12 = "-- Not Available --";
                    string Grid_I3n_12_I3n13 = "-- Not Available --";
                    string Grid_I3n_12_I3n17 = "-- Not Available --";
                    string Grid_I3n_12_I3n18 = "-- Not Available --";
                    string Grid_I3n_12_I3n19 = "-- Not Available --";
                    string Grid_I3n_12_I3n20 = "-- Not Available --";
                    string Grid_I3n_25_I3n03 = "-- Not Available --";
                    string Grid_I3n_25_I3n04 = "-- Not Available --";
                    string Grid_I3n_25_I3n05 = "-- Not Available --";
                    string Grid_I3n_25_I3n08 = "-- Not Available --";
                    string Grid_I3n_25_I3n12 = "-- Not Available --";
                    string Grid_I3n_25_I3n13 = "-- Not Available --";
                    string Grid_I3n_25_I3n17 = "-- Not Available --";
                    string Grid_I3n_25_I3n18 = "-- Not Available --";
                    string Grid_I3n_25_I3n19 = "-- Not Available --";
                    string Grid_I3n_25_I3n20 = "-- Not Available --";
                    string Grid_I3n_26_I3n03 = "-- Not Available --";
                    string Grid_I3n_26_I3n04 = "-- Not Available --";
                    string Grid_I3n_26_I3n05 = "-- Not Available --";
                    string Grid_I3n_26_I3n08 = "-- Not Available --";
                    string Grid_I3n_26_I3n12 = "-- Not Available --";
                    string Grid_I3n_26_I3n13 = "-- Not Available --";
                    string Grid_I3n_26_I3n17 = "-- Not Available --";
                    string Grid_I3n_26_I3n18 = "-- Not Available --";
                    string Grid_I3n_26_I3n19 = "-- Not Available --";
                    string Grid_I3n_26_I3n20 = "-- Not Available --";
                    string Grid_I3n_29_I3n03 = "-- Not Available --";
                    string Grid_I3n_29_I3n04 = "-- Not Available --";
                    string Grid_I3n_29_I3n05 = "-- Not Available --";
                    string Grid_I3n_29_I3n08 = "-- Not Available --";
                    string Grid_I3n_29_I3n12 = "-- Not Available --";
                    string Grid_I3n_29_I3n13 = "-- Not Available --";
                    string Grid_I3n_29_I3n17 = "-- Not Available --";
                    string Grid_I3n_29_I3n18 = "-- Not Available --";
                    string Grid_I3n_29_I3n19 = "-- Not Available --";
                    string Grid_I3n_29_I3n20 = "-- Not Available --";
                    string Grid_I3n_47_I3n03 = "-- Not Available --";
                    string Grid_I3n_47_I3n04 = "-- Not Available --";
                    string Grid_I3n_47_I3n05 = "-- Not Available --";
                    string Grid_I3n_47_I3n08 = "-- Not Available --";
                    string Grid_I3n_47_I3n12 = "-- Not Available --";
                    string Grid_I3n_47_I3n13 = "-- Not Available --";
                    string Grid_I3n_47_I3n17 = "-- Not Available --";
                    string Grid_I3n_47_I3n18 = "-- Not Available --";
                    string Grid_I3n_47_I3n19 = "-- Not Available --";
                    string Grid_I3n_47_I3n20 = "-- Not Available --";
                    string Grid_I3n_51_I3n03 = "-- Not Available --";
                    string Grid_I3n_51_I3n04 = "-- Not Available --";
                    string Grid_I3n_51_I3n05 = "-- Not Available --";
                    string Grid_I3n_51_I3n08 = "-- Not Available --";
                    string Grid_I3n_51_I3n12 = "-- Not Available --";
                    string Grid_I3n_51_I3n13 = "-- Not Available --";
                    string Grid_I3n_51_I3n17 = "-- Not Available --";
                    string Grid_I3n_51_I3n18 = "-- Not Available --";
                    string Grid_I3n_51_I3n19 = "-- Not Available --";
                    string Grid_I3n_51_I3n20 = "-- Not Available --";

                    foreach (var variable in spssDataset.Variables)
                    {
                        foreach (string spss_v in spss_variable_name)
                        {
                            if (variable.Name.Equals(spss_v))
                            {
                                variable_name = variable.Name;

                                switch (variable_name)
                                {
                                    case "CN":
                                        {
                                            u_id = Convert.ToString(record.GetValue(variable));
                                            userID = find_UserId(SurveyID, AttendedOn, u_id);
                                            break;
                                        }
                                    case "weight":
                                        {
                                            Weight = Convert.ToDecimal(record.GetValue(variable));
                                            break;
                                        }
                                    case "SEC": { SES = Convert.ToString(record.GetValue(variable)); break; }
                                    case "BAREA": { Location = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S3a": { AgeGroup = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GEN": { Gender = Convert.ToString(record.GetValue(variable)); break; }
                                    case "D1": { MaritalStatus = Convert.ToString(record.GetValue(variable)); break; }
                                    case "D4": { Occupation = Convert.ToString(record.GetValue(variable)); break; }
                                    case "D3": { Education = Convert.ToString(record.GetValue(variable)); break; }
                                    case "WAVE": { period = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1": { BrTom = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_1": { BrSpont_Absolute_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_11": { BrSpont_Nature_Spring_Alkaline_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_12": { BrSpont_Nature_Spring_Distilled_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_13": { BrSpont_Nature_Spring_Purified_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_25": { BrSpont_Refresh_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_26": { BrSpont_Refresh_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_29": { BrSpont_Summit_Spring_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_45": { BrSpont_Wet_Water_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_47": { BrSpont_Wilkins_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_51": { BrSpont_Wilkins_Pure_Water_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_54": { BrSpont_LE_MINERALE = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_80": { BrSpont_Sip_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_81": { BrSpont_Aquafina_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_1": { BrAided_Absolute_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_11": { BrAided_Nature_Spring_Alkaline_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_12": { BrAided_Nature_Spring_Distilled_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_13": { BrAided_Nature_Spring_Purified_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_25": { BrAided_Refresh_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_26": { BrAided_Refresh_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_29": { BrAided_Summit_Spring_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_45": { BrAided_Wet_Water_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_47": { BrAided_Wilkins_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_51": { BrAided_Wilkins_Pure_Water_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_54": { BrAided_LE_MINERALE = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_80": { BrAided_Sip_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_81": { BrAided_Aquafina_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOM": { AdTom = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_1": { AdSpont_Absolute_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_11": { AdSpont_Nature_Spring_Alkaline_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_12": { AdSpont_Nature_Spring_Distilled_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_13": { AdSpont_Nature_Spring_Purified_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_25": { AdSpont_Refresh_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_26": { AdSpont_Refresh_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_29": { AdSpont_Summit_Spring_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_45": { AdSpont_Wet_Water_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_47": { AdSpont_Wilkins_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_51": { AdSpont_Wilkins_Pure_Water_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_54": { AdSpont_LE_MINERALE = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_80": { AdSpont_Sip_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOTAL_81": { AdSpont_Aquafina_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_1" : { AdAided_Absolute_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_11": { AdAided_Nature_Spring_Alkaline_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_12": { AdAided_Nature_Spring_Distilled_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_13": { AdAided_Nature_Spring_Purified_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_25": { AdAided_Refresh_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_26": { AdAided_Refresh_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_29": { AdAided_Summit_Spring_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_45": { AdAided_Wet_Water_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_47": { AdAided_Wilkins_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_51": { AdAided_Wilkins_Pure_Water_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_54": { AdAided_LE_MINERALE = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_80": { AdAided_Sip_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3B5_81": { AdAided_Aquafina_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B9": { Bumo = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B11": { PerBUMO = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B12": { Favourite_Brand = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B14": { Br_LikelyToSwitch_To = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_1": { EverTried_Absolute_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_11": { EverTried_Nature_Spring_Alkaline_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_12": { EverTried_Nature_Spring_Distilled_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_13": { EverTried_Nature_Spring_Purified_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_25": { EverTried_Refresh_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_26": { EverTried_Refresh_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_29": { EverTried_Summit_Spring_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_45": { EverTried_Wet_Water_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_47": { EverTried_Wilkins_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_51": { EverTried_Wilkins_Pure_Water_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_54": { EverTried_LE_MINERALE = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_80": { EverTried_Sip_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_B6_1_81": { EverTried_Aquafina_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_1": { ConsP3M_Absolute_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_11": { ConsP3M_Nature_Spring_Alkaline_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_12": { ConsP3M_Nature_Spring_Distilled_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_13": { ConsP3M_Nature_Spring_Purified_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_25": { ConsP3M_Refresh_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_26": { ConsP3M_Refresh_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_29": { ConsP3M_Summit_Spring_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_45": { ConsP3M_Wet_Water_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_47": { ConsP3M_Wilkins_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_51": { ConsP3M_Wilkins_Pure_Water_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_54": { ConsP3M_LE_MINERALE = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_80": { ConsP3M_Sip_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_81": { ConsP3M_Aquafina_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_1": { Br_L_Used_Absolute_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_11": { Br_L_Used_Nature_Spring_Alkaline_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_12": { Br_L_Used_Nature_Spring_Distilled_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_13": { Br_L_Used_Nature_Spring_Purified_DW = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_25": { Br_L_Used_Refresh_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_26": { Br_L_Used_Refresh_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_29": { Br_L_Used_Summit_Spring_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_45": { Br_L_Used_Wet_Water_Mineral_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_47": { Br_L_Used_Wilkins_Distilled_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_51": { Br_L_Used_Wilkins_Pure_Water_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_54": { Br_L_Used_LE_MINERALE = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_80": { Br_L_Used_Sip_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_81": { Br_L_Used_Aquafina_Purified_W = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1_NET": { NetBrTom = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_NET_5001": { BrSpont_ABSOLUTE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_NET_5006": { BrSpont_LE_MINERALE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_NET_5007": { BrSpont_NATURE_SPRING_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_NET_5011": { BrSpont_SUMMIT_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_NET_5014": { BrSpont_WILKINS_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_NET_5001": { BrAided_ABSOLUTE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_NET_5006": { BrAided_LE_MINERALE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_NET_5007": { BrAided_NATURE_SPRING_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_NET_5011": { BrAided_SUMMIT_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1B2B4_NET_5014": { BrAided_WILKINS_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3_TOM_NET": { AdTom_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_NET_5001": { AdSpont_ABSOLUTE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_NET_5006": { AdSpont_LE_MINERALE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_NET_5007": { AdSpont_NATURE_SPRING_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_NET_5011": { AdSpont_SUMMIT_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_NET_5014": { AdSpont_WILKINS_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_B5_NET_5001": { AdAided_ABSOLUTE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_B5_NET_5006": { AdAided_LE_MINERALE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_B5_NET_5007": { AdAided_NATURE_SPRING_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_B5_NET_5011": { AdAided_SUMMIT_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3TOM_B3OM_B5_NET_5014": { AdAided_WILKINS_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6B6_1_NET_5001": { Br_Ever_tried_ABSOLUTE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6B6_1_NET_5006": { Br_Ever_tried_LE_MINERALE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6B6_1_NET_5007": { Br_Ever_tried_NATURE_SPRING_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6B6_1_NET_5011": { Br_Ever_tried_SUMMIT_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6B6_1_NET_5014": { Br_Ever_tried_WILKINS_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_NET_5001": { REG_BR_P3M_ABSOLUTE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_NET_5006": { REG_BR_P3M_LE_MINERALE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_NET_5007": { REG_BR_P3M_NATURE_SPRING_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_NET_5011": { REG_BR_P3M_SUMMIT_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_NET_5014": { REG_BR_P3M_WILKINS_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B9_NET": { NetBumo = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B12_NET": { NetFavourite_Brand = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B11_NET": { NetPerBUMO = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B14_NET": { NetBrLikely = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B15_NET_1_B15_NET_5001": { Freq_Cons_ABSOLUTE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B15_NET_1_B15_NET_5006": { Freq_Cons_LE_MINERALE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B15_NET_1_B15_NET_5007": { Freq_Cons_NATURE_SPRING_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B15_NET_1_B15_NET_5011": { Freq_Cons_SUMMIT_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B15_NET_1_B15_NET_5014": { Freq_Cons_WILKINS_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B7_NET_1_B7_NET_5001": { Br_used_ABSOLUTE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B7_NET_1_B7_NET_5006": { Br_used_LE_MINERALE_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B7_NET_1_B7_NET_5007": { Br_used_NATURE_SPRING_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "GRID_B7_NET_1_B7_NET_5011": { Br_used_SUMMIT_NET = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_1": { Cat_Cons_P6M_Plain_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_2": { Cat_Cons_P6M_Flavored_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_3": { Cat_Cons_P6M_RTD_Coffee = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_4": { Cat_Cons_P6M_Softdrinks = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_5": { Cat_Cons_P6M_Chocolate_drink = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_6": { Cat_Cons_P6M_RTD_Juices = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_7": { Cat_Cons_P6M_RTD_Iced_Tea = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_8": { Cat_Cons_P6M_Soya_Milk_unflavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S5_9": { Cat_Cons_P6M_Soya_Milk_flavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_1": { Cat_Cons_P3M_Plain_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_2": { Cat_Cons_P3M_Flavored_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_3": { Cat_Cons_P3M_RTD_Coffee = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_4": { Cat_Cons_P3M_Softdrinks = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_5": { Cat_Cons_P3M_Chocolate_drink = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_6": { Cat_Cons_P3M_RTD_Juices = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_7": { Cat_Cons_P3M_RTD_Iced_Tea = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_8": { Cat_Cons_P3M_Soya_Milk_unflavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S6_9": { Cat_Cons_P3M_Soya_Milk_flavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_1": { Cat_Cons_P1M_Plain_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_2": { Cat_Cons_P1M_Flavored_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_3": { Cat_Cons_P1M_RTD_Coffee = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_4": { Cat_Cons_P1M_Softdrinks = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_5": { Cat_Cons_P1M_Chocolate_drink = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_6": { Cat_Cons_P1M_RTD_Juices = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_7": { Cat_Cons_P1M_RTD_Iced_Tea = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_8": { Cat_Cons_P1M_Soya_Milk_unflavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S7_9": { Cat_Cons_P1M_Soya_Milk_flavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1": { Cat_Cons_P1W_Plain_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_2": { Cat_Cons_P1W_Flavored_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_3": { Cat_Cons_P1W_RTD_Coffee = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_4": { Cat_Cons_P1W_Softdrinks = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_5": { Cat_Cons_P1W_Chocolate_drink = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_6": { Cat_Cons_P1W_RTD_Juices = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_7": { Cat_Cons_P1W_RTD_Iced_Tea = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_8": { Cat_Cons_P1W_Soya_Milk_unflavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_9": { Cat_Cons_P1W_Soya_Milk_flavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_1": { Cat_Cons_Daily_Plain_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_2": { Cat_Cons_Daily_Flavored_Bottled_Water = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_3": { Cat_Cons_Daily_RTD_Coffee = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_4": { Cat_Cons_Daily_Softdrinks = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_5": { Cat_Cons_Daily_Chocolate_drink = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_6": { Cat_Cons_Daily_RTD_Juices = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_7": { Cat_Cons_Daily_RTD_Iced_Tea = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_8": { Cat_Cons_Daily_Soya_Milk_unflavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8_1_9": { Cat_Cons_Daily_Soya_Milk_flavored = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n03": { Grid_I3n_1_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n04": { Grid_I3n_1_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n05": { Grid_I3n_1_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n08": { Grid_I3n_1_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n12": { Grid_I3n_1_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n13": { Grid_I3n_1_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n17": { Grid_I3n_1_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n18": { Grid_I3n_1_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n19": { Grid_I3n_1_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_1_I3n20": { Grid_I3n_1_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n03": { Grid_I3n_81_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n04": { Grid_I3n_81_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n05": { Grid_I3n_81_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n08": { Grid_I3n_81_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n12": { Grid_I3n_81_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n13": { Grid_I3n_81_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n17": { Grid_I3n_81_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n18": { Grid_I3n_81_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n19": { Grid_I3n_81_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_81_I3n20": { Grid_I3n_81_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n03": { Grid_I3n_54_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n04": { Grid_I3n_54_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n05": { Grid_I3n_54_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n08": { Grid_I3n_54_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n12": { Grid_I3n_54_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n13": { Grid_I3n_54_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n17": { Grid_I3n_54_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n18": { Grid_I3n_54_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n19": { Grid_I3n_54_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_54_I3n20": { Grid_I3n_54_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n03": { Grid_I3n_11_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n04": { Grid_I3n_11_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n05": { Grid_I3n_11_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n08": { Grid_I3n_11_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n12": { Grid_I3n_11_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n13": { Grid_I3n_11_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n17": { Grid_I3n_11_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n18": { Grid_I3n_11_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n19": { Grid_I3n_11_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_11_I3n20": { Grid_I3n_11_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n03": { Grid_I3n_12_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n04": { Grid_I3n_12_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n05": { Grid_I3n_12_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n08": { Grid_I3n_12_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n12": { Grid_I3n_12_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n13": { Grid_I3n_12_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n17": { Grid_I3n_12_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n18": { Grid_I3n_12_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n19": { Grid_I3n_12_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_12_I3n20": { Grid_I3n_12_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n03": { Grid_I3n_25_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n04": { Grid_I3n_25_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n05": { Grid_I3n_25_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n08": { Grid_I3n_25_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n12": { Grid_I3n_25_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n13": { Grid_I3n_25_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n17": { Grid_I3n_25_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n18": { Grid_I3n_25_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n19": { Grid_I3n_25_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_25_I3n20": { Grid_I3n_25_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n03": { Grid_I3n_26_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n04": { Grid_I3n_26_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n05": { Grid_I3n_26_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n08": { Grid_I3n_26_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n12": { Grid_I3n_26_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n13": { Grid_I3n_26_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n17": { Grid_I3n_26_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n18": { Grid_I3n_26_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n19": { Grid_I3n_26_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_26_I3n20": { Grid_I3n_26_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n03": { Grid_I3n_29_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n04": { Grid_I3n_29_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n05": { Grid_I3n_29_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n08": { Grid_I3n_29_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n12": { Grid_I3n_29_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n13": { Grid_I3n_29_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n17": { Grid_I3n_29_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n18": { Grid_I3n_29_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n19": { Grid_I3n_29_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_29_I3n20": { Grid_I3n_29_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n03": { Grid_I3n_47_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n04": { Grid_I3n_47_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n05": { Grid_I3n_47_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n08": { Grid_I3n_47_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n12": { Grid_I3n_47_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n13": { Grid_I3n_47_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n17": { Grid_I3n_47_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n18": { Grid_I3n_47_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n19": { Grid_I3n_47_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_47_I3n20": { Grid_I3n_47_I3n20 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n03": { Grid_I3n_51_I3n03 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n04": { Grid_I3n_51_I3n04 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n05": { Grid_I3n_51_I3n05 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n08": { Grid_I3n_51_I3n08 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n12": { Grid_I3n_51_I3n12 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n13": { Grid_I3n_51_I3n13 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n17": { Grid_I3n_51_I3n17 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n18": { Grid_I3n_51_I3n18 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n19": { Grid_I3n_51_I3n19 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "Grid_I3n_51_I3n20": { Grid_I3n_51_I3n20 = Convert.ToString(record.GetValue(variable)); break; }

                                }

                            }
                        }
                    }

                    if (userID != null && Weight != 0 )
                    {
                        iobj.insert_Dashboard_values(userID, AttendedOn, Weight, SurveyID, country, SES, Location, AgeGroup, Gender, MaritalStatus, Occupation, Education, period, BrTom, BrSpont_Absolute_Distilled_W, BrSpont_Nature_Spring_Alkaline_DW, BrSpont_Nature_Spring_Distilled_DW, BrSpont_Nature_Spring_Purified_DW, BrSpont_Refresh_Mineral_W, BrSpont_Refresh_Purified_W, BrSpont_Summit_Spring_W, BrSpont_Wet_Water_Mineral_W, BrSpont_Wilkins_Distilled_W, BrSpont_Wilkins_Pure_Water_Purified_W, BrSpont_LE_MINERALE, BrSpont_Sip_Purified_W, BrSpont_Aquafina_Purified_W, BrAided_Absolute_Distilled_W, BrAided_Nature_Spring_Alkaline_DW, BrAided_Nature_Spring_Distilled_DW, BrAided_Nature_Spring_Purified_DW, BrAided_Refresh_Mineral_W, BrAided_Refresh_Purified_W, BrAided_Summit_Spring_W, BrAided_Wet_Water_Mineral_W, BrAided_Wilkins_Distilled_W, BrAided_Wilkins_Pure_Water_Purified_W, BrAided_LE_MINERALE, BrAided_Sip_Purified_W, BrAided_Aquafina_Purified_W, AdTom, AdSpont_Absolute_Distilled_W, AdSpont_Nature_Spring_Alkaline_DW, AdSpont_Nature_Spring_Distilled_DW, AdSpont_Nature_Spring_Purified_DW, AdSpont_Refresh_Mineral_W, AdSpont_Refresh_Purified_W, AdSpont_Summit_Spring_W, AdSpont_Wet_Water_Mineral_W, AdSpont_Wilkins_Distilled_W, AdSpont_Wilkins_Pure_Water_Purified_W, AdSpont_LE_MINERALE, AdSpont_Sip_Purified_W, AdSpont_Aquafina_Purified_W, AdAided_Absolute_Distilled_W, AdAided_Nature_Spring_Alkaline_DW, AdAided_Nature_Spring_Distilled_DW, AdAided_Nature_Spring_Purified_DW, AdAided_Refresh_Mineral_W, AdAided_Refresh_Purified_W, AdAided_Summit_Spring_W, AdAided_Wet_Water_Mineral_W, AdAided_Wilkins_Distilled_W, AdAided_Wilkins_Pure_Water_Purified_W, AdAided_LE_MINERALE, AdAided_Sip_Purified_W, AdAided_Aquafina_Purified_W, Bumo, PerBUMO, Favourite_Brand, Br_LikelyToSwitch_To, EverTried_Absolute_Distilled_W, EverTried_Nature_Spring_Alkaline_DW, EverTried_Nature_Spring_Distilled_DW, EverTried_Nature_Spring_Purified_DW, EverTried_Refresh_Mineral_W, EverTried_Refresh_Purified_W, EverTried_Summit_Spring_W, EverTried_Wet_Water_Mineral_W, EverTried_Wilkins_Distilled_W, EverTried_Wilkins_Pure_Water_Purified_W, EverTried_LE_MINERALE, EverTried_Sip_Purified_W, EverTried_Aquafina_Purified_W, ConsP3M_Absolute_Distilled_W, ConsP3M_Nature_Spring_Alkaline_DW, ConsP3M_Nature_Spring_Distilled_DW, ConsP3M_Nature_Spring_Purified_DW, ConsP3M_Refresh_Mineral_W, ConsP3M_Refresh_Purified_W, ConsP3M_Summit_Spring_W, ConsP3M_Wet_Water_Mineral_W, ConsP3M_Wilkins_Distilled_W, ConsP3M_Wilkins_Pure_Water_Purified_W, ConsP3M_LE_MINERALE, ConsP3M_Sip_Purified_W, ConsP3M_Aquafina_Purified_W, Br_L_Used_Absolute_Distilled_W, Br_L_Used_Nature_Spring_Alkaline_DW, Br_L_Used_Nature_Spring_Distilled_DW, Br_L_Used_Nature_Spring_Purified_DW, Br_L_Used_Refresh_Mineral_W, Br_L_Used_Refresh_Purified_W, Br_L_Used_Summit_Spring_W, Br_L_Used_Wet_Water_Mineral_W, Br_L_Used_Wilkins_Distilled_W, Br_L_Used_Wilkins_Pure_Water_Purified_W, Br_L_Used_LE_MINERALE, Br_L_Used_Sip_Purified_W, Br_L_Used_Aquafina_Purified_W, NetBrTom, BrSpont_ABSOLUTE_NET, BrSpont_LE_MINERALE_NET, BrSpont_NATURE_SPRING_NET, BrSpont_SUMMIT_NET, BrSpont_WILKINS_NET, BrAided_ABSOLUTE_NET, BrAided_LE_MINERALE_NET, BrAided_NATURE_SPRING_NET, BrAided_SUMMIT_NET, BrAided_WILKINS_NET, AdTom_NET, AdSpont_ABSOLUTE_NET, AdSpont_LE_MINERALE_NET, AdSpont_NATURE_SPRING_NET, AdSpont_SUMMIT_NET, AdSpont_WILKINS_NET, AdAided_ABSOLUTE_NET, AdAided_LE_MINERALE_NET, AdAided_NATURE_SPRING_NET, AdAided_SUMMIT_NET, AdAided_WILKINS_NET, Br_Ever_tried_ABSOLUTE_NET, Br_Ever_tried_LE_MINERALE_NET, Br_Ever_tried_NATURE_SPRING_NET, Br_Ever_tried_SUMMIT_NET, Br_Ever_tried_WILKINS_NET, REG_BR_P3M_ABSOLUTE_NET, REG_BR_P3M_LE_MINERALE_NET, REG_BR_P3M_NATURE_SPRING_NET, REG_BR_P3M_SUMMIT_NET, REG_BR_P3M_WILKINS_NET, NetBumo, NetFavourite_Brand, NetPerBUMO, NetBrLikely, Freq_Cons_ABSOLUTE_NET, Freq_Cons_LE_MINERALE_NET, Freq_Cons_NATURE_SPRING_NET, Freq_Cons_SUMMIT_NET, Freq_Cons_WILKINS_NET, Br_used_ABSOLUTE_NET, Br_used_LE_MINERALE_NET, Br_used_NATURE_SPRING_NET, Br_used_SUMMIT_NET, Cat_Cons_P6M_Plain_Bottled_Water,Cat_Cons_P6M_Flavored_Bottled_Water, Cat_Cons_P6M_RTD_Coffee, Cat_Cons_P6M_Softdrinks, Cat_Cons_P6M_Chocolate_drink, Cat_Cons_P6M_RTD_Juices, Cat_Cons_P6M_RTD_Iced_Tea, Cat_Cons_P6M_Soya_Milk_unflavored, Cat_Cons_P6M_Soya_Milk_flavored, Cat_Cons_P3M_Plain_Bottled_Water, Cat_Cons_P3M_Flavored_Bottled_Water, Cat_Cons_P3M_RTD_Coffee, Cat_Cons_P3M_Softdrinks, Cat_Cons_P3M_Chocolate_drink, Cat_Cons_P3M_RTD_Juices, Cat_Cons_P3M_RTD_Iced_Tea, Cat_Cons_P3M_Soya_Milk_unflavored, Cat_Cons_P3M_Soya_Milk_flavored, Cat_Cons_P1M_Plain_Bottled_Water, Cat_Cons_P1M_Flavored_Bottled_Water, Cat_Cons_P1M_RTD_Coffee, Cat_Cons_P1M_Softdrinks, Cat_Cons_P1M_Chocolate_drink, Cat_Cons_P1M_RTD_Juices, Cat_Cons_P1M_RTD_Iced_Tea, Cat_Cons_P1M_Soya_Milk_unflavored, Cat_Cons_P1M_Soya_Milk_flavored, Cat_Cons_P1W_Plain_Bottled_Water, Cat_Cons_P1W_Flavored_Bottled_Water, Cat_Cons_P1W_RTD_Coffee, Cat_Cons_P1W_Softdrinks, Cat_Cons_P1W_Chocolate_drink, Cat_Cons_P1W_RTD_Juices, Cat_Cons_P1W_RTD_Iced_Tea, Cat_Cons_P1W_Soya_Milk_unflavored, Cat_Cons_P1W_Soya_Milk_flavored, Cat_Cons_Daily_Plain_Bottled_Water, Cat_Cons_Daily_Flavored_Bottled_Water, Cat_Cons_Daily_RTD_Coffee, Cat_Cons_Daily_Softdrinks, Cat_Cons_Daily_Chocolate_drink, Cat_Cons_Daily_RTD_Juices, Cat_Cons_Daily_RTD_Iced_Tea, Cat_Cons_Daily_Soya_Milk_unflavored, Cat_Cons_Daily_Soya_Milk_flavored, Grid_I3n_1_I3n03, Grid_I3n_1_I3n04, Grid_I3n_1_I3n05, Grid_I3n_1_I3n08, Grid_I3n_1_I3n12, Grid_I3n_1_I3n13, Grid_I3n_1_I3n17, Grid_I3n_1_I3n18, Grid_I3n_1_I3n19, Grid_I3n_1_I3n20, Grid_I3n_81_I3n03, Grid_I3n_81_I3n04, Grid_I3n_81_I3n05, Grid_I3n_81_I3n08, Grid_I3n_81_I3n12, Grid_I3n_81_I3n13, Grid_I3n_81_I3n17, Grid_I3n_81_I3n18, Grid_I3n_81_I3n19, Grid_I3n_81_I3n20, Grid_I3n_54_I3n03, Grid_I3n_54_I3n04, Grid_I3n_54_I3n05, Grid_I3n_54_I3n08, Grid_I3n_54_I3n12, Grid_I3n_54_I3n13, Grid_I3n_54_I3n17, Grid_I3n_54_I3n18, Grid_I3n_54_I3n19, Grid_I3n_54_I3n20, Grid_I3n_11_I3n03, Grid_I3n_11_I3n04, Grid_I3n_11_I3n05, Grid_I3n_11_I3n08, Grid_I3n_11_I3n12, Grid_I3n_11_I3n13, Grid_I3n_11_I3n17, Grid_I3n_11_I3n18, Grid_I3n_11_I3n19, Grid_I3n_11_I3n20, Grid_I3n_12_I3n03, Grid_I3n_12_I3n04, Grid_I3n_12_I3n05, Grid_I3n_12_I3n08, Grid_I3n_12_I3n12, Grid_I3n_12_I3n13, Grid_I3n_12_I3n17, Grid_I3n_12_I3n18, Grid_I3n_12_I3n19, Grid_I3n_12_I3n20, Grid_I3n_25_I3n03, Grid_I3n_25_I3n04, Grid_I3n_25_I3n05, Grid_I3n_25_I3n08, Grid_I3n_25_I3n12, Grid_I3n_25_I3n13, Grid_I3n_25_I3n17, Grid_I3n_25_I3n18, Grid_I3n_25_I3n19, Grid_I3n_25_I3n20, Grid_I3n_26_I3n03, Grid_I3n_26_I3n04, Grid_I3n_26_I3n05, Grid_I3n_26_I3n08, Grid_I3n_26_I3n12, Grid_I3n_26_I3n13, Grid_I3n_26_I3n17, Grid_I3n_26_I3n18, Grid_I3n_26_I3n19, Grid_I3n_26_I3n20, Grid_I3n_29_I3n03, Grid_I3n_29_I3n04, Grid_I3n_29_I3n05, Grid_I3n_29_I3n08, Grid_I3n_29_I3n12, Grid_I3n_29_I3n13, Grid_I3n_29_I3n17, Grid_I3n_29_I3n18, Grid_I3n_29_I3n19, Grid_I3n_29_I3n20, Grid_I3n_47_I3n03, Grid_I3n_47_I3n04, Grid_I3n_47_I3n05, Grid_I3n_47_I3n08, Grid_I3n_47_I3n12, Grid_I3n_47_I3n13, Grid_I3n_47_I3n17, Grid_I3n_47_I3n18, Grid_I3n_47_I3n19, Grid_I3n_47_I3n20, Grid_I3n_51_I3n03, Grid_I3n_51_I3n04, Grid_I3n_51_I3n05, Grid_I3n_51_I3n08, Grid_I3n_51_I3n12, Grid_I3n_51_I3n13, Grid_I3n_51_I3n17, Grid_I3n_51_I3n18, Grid_I3n_51_I3n19, Grid_I3n_51_I3n20);
                    }
                }
            }
        }
        private static string find_UserId(int SurveyID, string SurveyPeriod, string u_id)
        {
            string sum = "";
            string[] date = SurveyPeriod.Split('-');
            foreach (string d in date)
            {
                sum = sum + d;

            }
            return u_id + SurveyID + sum;
        }
    }
}
