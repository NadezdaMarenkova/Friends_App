using SQLite; 
using System;
using System.Collections.Generic;
using System.Text;

namespace Friends_App
{
    //Класс Friend выступает в качестве модели приложения. Этот класс использует атрибуты, которые позволяют настроить его отображение на таблицу в бд. 

    [Table("Friends")]
    public class Friend
    {
        [PrimaryKey, AutoIncrement, Column ("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
