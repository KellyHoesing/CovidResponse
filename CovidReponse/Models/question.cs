﻿using System;
namespace CovidReponse.Models
{
    public class question
    {
        public question()
        {
        }

        public int question_ID { get; set; }
        public string text { get; set; }
        public string place_type { get; set; }
        public string point_type { get; set; }
        public DateTime entered_date { get; set; }


    }
}
