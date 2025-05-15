﻿namespace PasswordManagerAPI.Entitys
{
    public abstract class ParentEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; } = "System";
        public string? UpdatedBy { get; set; }
        public DateTime CreationDate { get; set; }= DateTime.Now;
        public DateTime? UpdatedDate { get;  set; }
        public bool IsActive { get; set; } = true;
    }
}
