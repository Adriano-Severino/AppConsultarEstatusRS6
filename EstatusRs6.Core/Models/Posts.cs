//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EstatusRs6.Core.Models
//{


//    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 


//    public class Rootobject
//    {
//        public bool authorized { get; set; }
//        public int status { get; set; }
//        public bool foundmatch { get; set; }
//        public string requested { get; set; }
//        public Players players { get; set; }
//    }

//    public class Players
//    {
//        public List<Player> Player { get; set; }
//    }

//    public class Player
//    {
//        public Profile profile { get; set; }
//        public Refresh refresh { get; set; }
//        public Stats stats { get; set; }
//        public Ranked ranked { get; set; }
//    }

//    public class Profile
//    {
//        public string p_id { get; set; }
//        public string p_name { get; set; }
//        public string p_user { get; set; }
//        public string p_platform { get; set; }
//        public bool verified { get; set; }
//        public string information { get; set; }
//    }

//    public class Refresh
//    {
//        public int x { get; set; }
//        public int s { get; set; }
//    }

//    public class Stats
//    {
//        public int level { get; set; }
//    }

//    public class Ranked
//    {
//        public float kd { get; set; }
//        public int mmr { get; set; }
//        public int rank { get; set; }
//        public int champ { get; set; }
//        public int NA_mmr { get; set; }
//        public int NA_rank { get; set; }
//        public int NA_champ { get; set; }
//        public int EU_mmr { get; set; }
//        public int EU_rank { get; set; }
//        public int EU_champ { get; set; }
//        public int AS_mmr { get; set; }
//        public int AS_rank { get; set; }
//        public int AS_champ { get; set; }
//    }


//    //public class Root
//    //{
//    //    public List<Posts> Posts { get; set; }
//    //}

//}
