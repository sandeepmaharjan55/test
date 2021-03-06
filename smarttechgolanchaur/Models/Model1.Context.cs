﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace smarttechgolanchaur.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class villageprofileEntities : DbContext
    {
        public villageprofileEntities()
            : base("name=villageprofileEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<api_users> api_users { get; set; }
        public virtual DbSet<article> articles { get; set; }
        public virtual DbSet<audit> audits { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<custom_settings> custom_settings { get; set; }
        public virtual DbSet<email_templates> email_templates { get; set; }
        public virtual DbSet<emergency_services> emergency_services { get; set; }
        public virtual DbSet<gallery> galleries { get; set; }
        public virtual DbSet<gallery_lang_contents> gallery_lang_contents { get; set; }
        public virtual DbSet<lang_translations> lang_translations { get; set; }
        public virtual DbSet<lang_words> lang_words { get; set; }
        public virtual DbSet<language> languages { get; set; }
        public virtual DbSet<language_category> language_category { get; set; }
        public virtual DbSet<login_logs> login_logs { get; set; }
        public virtual DbSet<log> logs { get; set; }
        public virtual DbSet<migration> migrations { get; set; }
        public virtual DbSet<oauth_access_tokens> oauth_access_tokens { get; set; }
        public virtual DbSet<oauth_auth_codes> oauth_auth_codes { get; set; }
        public virtual DbSet<oauth_clients> oauth_clients { get; set; }
        public virtual DbSet<oauth_personal_access_clients> oauth_personal_access_clients { get; set; }
        public virtual DbSet<oauth_refresh_tokens> oauth_refresh_tokens { get; set; }
        public virtual DbSet<page_lang_contents> page_lang_contents { get; set; }
        public virtual DbSet<page> pages { get; set; }
        public virtual DbSet<permission> permissions { get; set; }
        public virtual DbSet<photo_lang_contents> photo_lang_contents { get; set; }
        public virtual DbSet<photo> photos { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<security_settings> security_settings { get; set; }
        public virtual DbSet<setting> settings { get; set; }
        public virtual DbSet<system_languages> system_languages { get; set; }
        public virtual DbSet<table_house_senior_details> table_house_senior_details { get; set; }
        public virtual DbSet<tbl_address> tbl_address { get; set; }
        public virtual DbSet<tbl_cast> tbl_cast { get; set; }
        public virtual DbSet<tbl_education> tbl_education { get; set; }
        public virtual DbSet<tbl_family_bank_accounts> tbl_family_bank_accounts { get; set; }
        public virtual DbSet<tbl_family_cooking_resources> tbl_family_cooking_resources { get; set; }
        public virtual DbSet<tbl_family_light_resources> tbl_family_light_resources { get; set; }
        public virtual DbSet<tbl_family_toilet_resources> tbl_family_toilet_resources { get; set; }
        public virtual DbSet<tbl_familymember_insurance> tbl_familymember_insurance { get; set; }
        public virtual DbSet<tbl_familymember_water_resources> tbl_familymember_water_resources { get; set; }
        public virtual DbSet<tbl_gender> tbl_gender { get; set; }
        public virtual DbSet<tbl_health_condition> tbl_health_condition { get; set; }
        public virtual DbSet<tbl_house_details> tbl_house_details { get; set; }
        public virtual DbSet<tbl_house_owner_infos> tbl_house_owner_infos { get; set; }
        public virtual DbSet<tbl_jana_pratinidhi> tbl_jana_pratinidhi { get; set; }
        public virtual DbSet<tbl_marriage_condition> tbl_marriage_condition { get; set; }
        public virtual DbSet<tbl_mothertounge> tbl_mothertounge { get; set; }
        public virtual DbSet<tbl_owner_members> tbl_owner_members { get; set; }
        public virtual DbSet<tbl_physical_condition> tbl_physical_condition { get; set; }
        public virtual DbSet<tbl_profession> tbl_profession { get; set; }
        public virtual DbSet<tbl_religion> tbl_religion { get; set; }
        public virtual DbSet<tbl_ward> tbl_ward { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<password_resets> password_resets { get; set; }
        public virtual DbSet<role_user> role_user { get; set; }
    }
}
