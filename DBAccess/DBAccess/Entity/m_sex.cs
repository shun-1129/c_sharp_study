namespace DBAccess.Entity
{
    public class m_sex
    {
        public int m_sex_id { get; set; }
        public string? m_sex_logic_name { get; set; }
        public string? m_sex_physics_name { get; set; }
        public DateTime created_at { get; set; }
        public string? create_user { get; set; }
        public string? create_program { get; set; }
        public DateTime updated_at { get; set; }
        public string? update_user { get; set; }
        public string? update_program { get; set; }
        public bool is_deleted { get; set; }

    }
}
