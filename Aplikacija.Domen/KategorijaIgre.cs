using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aplikacija.Domen
{
    [Serializable]
    public class KategorijaIgre : IEntity
    {
        public int VideoIgraID { get; set; }
        public int KategorijaID { get; set; }

        public string TableName => "KategorijaIgre";

        public string InsertValues => $"{VideoIgraID}, {KategorijaID}";

        public string UpdateValues => $"VideoIgraID = {VideoIgraID}, KategorijaID = {KategorijaID}";

        public string RecordID => $"VideoIgraID = {VideoIgraID}";// AND KategorijaID = {KategorijaID}";

        public string Join => string.Empty;

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> gamecategories = new List<IEntity>();
            while (reader.Read())
            {
                KategorijaIgre ki = new KategorijaIgre
                {
                    VideoIgraID  = (int)reader[0],
                    KategorijaID = (int)reader[1]
                };
                gamecategories.Add(ki);
            }
            return gamecategories;
        }

        public KategorijaIgre()
        {

        }

        public KategorijaIgre(int vid, int kid)
        {
            VideoIgraID = vid;
            KategorijaID = kid;
        }
    }
}