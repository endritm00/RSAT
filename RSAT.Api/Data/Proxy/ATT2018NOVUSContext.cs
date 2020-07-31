using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace RSAT.Api.Data.Proxy
{
    public partial class ATT2018NOVUSContext : DbContext
    {
        public ATT2018NOVUSContext()
        {
        }

        public ATT2018NOVUSContext(DbContextOptions<ATT2018NOVUSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessGroup> AccessGroup { get; set; }
        public virtual DbSet<AccessTime> AccessTime { get; set; }
        public virtual DbSet<BasePara> BasePara { get; set; }
        public virtual DbSet<Checkinout> Checkinout { get; set; }
        public virtual DbSet<CheckLog> CheckLog { get; set; }
        public virtual DbSet<DefineField> DefineField { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<FingerClient> FingerClient { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<LeaveClass> LeaveClass { get; set; }
        public virtual DbSet<MemStat> MemStat { get; set; }
        public virtual DbSet<Opclient> Opclient { get; set; }
        public virtual DbSet<Opdept> Opdept { get; set; }
        public virtual DbSet<Opgroup> Opgroup { get; set; }
        public virtual DbSet<Opinfo> Opinfo { get; set; }
        public virtual DbSet<Oplog> Oplog { get; set; }
        public virtual DbSet<OutProg> OutProg { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<SchTime> SchTime { get; set; }
        public virtual DbSet<StatItems> StatItems { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TimeTable> TimeTable { get; set; }
        public virtual DbSet<UserAutoClass> UserAutoClass { get; set; }
        public virtual DbSet<UserFinger> UserFinger { get; set; }
        public virtual DbSet<Userinfo> Userinfo { get; set; }
        public virtual DbSet<UserLeave> UserLeave { get; set; }
        public virtual DbSet<UserPower> UserPower { get; set; }
        public virtual DbSet<UserShift> UserShift { get; set; }
        public virtual DbSet<UserTempShift> UserTempShift { get; set; }
        public virtual DbSet<WorkCode> WorkCode { get; set; }
        public virtual DbSet<ZMemAbnor> ZMemAbnor { get; set; }
        public virtual DbSet<ZMemRecord> ZMemRecord { get; set; }
        public virtual DbSet<ZMemUclass> ZMemUclass { get; set; }

        public virtual DbSet<Task> Task { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Read the application configuration file => https://carlos.mendible.com/2016/07/11/step-by-step-dotnet-core-and-entity-framework-core/
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                var configuration = builder.Build();
                var connectionString = configuration["ProxyConnectionString"];
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessGroup>(entity =>
            {
                entity.Property(e => e.AccessGroupid).ValueGeneratedNever();

                entity.Property(e => e.AccessGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccessTimeid1).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccessTimeid2).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccessTimeid3).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccessTimeid4).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccessTime>(entity =>
            {
                entity.Property(e => e.AccessTimeid).ValueGeneratedNever();

                entity.Property(e => e.AccessTimeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FribeginTime)
                    .HasColumnName("FRIBeginTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.FriendTime)
                    .HasColumnName("FRIEndTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.MonbeginTime)
                    .HasColumnName("MONBeginTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.MonendTime)
                    .HasColumnName("MONEndTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.SatbeginTime)
                    .HasColumnName("SATBeginTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.SatendTime)
                    .HasColumnName("SATEndTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.SunbeginTime)
                    .HasColumnName("SUNBeginTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.SunendTime)
                    .HasColumnName("SUNEndTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.ThubeginTime)
                    .HasColumnName("THUBeginTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.ThuendTime)
                    .HasColumnName("THUEndTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.TuebeginTime)
                    .HasColumnName("TUEBeginTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.TueendTime)
                    .HasColumnName("TUEEndTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.WedbeginTime)
                    .HasColumnName("WEDBeginTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.WedendTime)
                    .HasColumnName("WEDEndTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");
            });

            modelBuilder.Entity<BasePara>(entity =>
            {
                entity.HasKey(e => e.Company);

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Companylogo).HasColumnType("image");

                entity.Property(e => e.Contacts)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField).HasColumnType("image");

                entity.Property(e => e.DeductIn).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeductOut).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FoverTime)
                    .HasColumnName("FOverTime")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GhLeave1).HasColumnName("gh_leave1");

                entity.Property(e => e.GhLeave2).HasColumnName("gh_leave2");

                entity.Property(e => e.GhLeave3).HasColumnName("gh_leave3");

                entity.Property(e => e.GrLeave1).HasColumnName("gr_leave1");

                entity.Property(e => e.GrLeave2).HasColumnName("gr_leave2");

                entity.Property(e => e.GrLeave3).HasColumnName("gr_leave3");

                entity.Property(e => e.GwLeave1).HasColumnName("gw_leave1");

                entity.Property(e => e.GwLeave2).HasColumnName("gw_leave2");

                entity.Property(e => e.GwLeave3).HasColumnName("gw_leave3");

                entity.Property(e => e.HoverTime)
                    .HasColumnName("HOverTime")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsoverTime).HasColumnName("ISOverTime");

                entity.Property(e => e.IsovertimeIn).HasDefaultValueSql("((0))");

                entity.Property(e => e.LateTime).HasDefaultValueSql("((60))");

                entity.Property(e => e.LeaveTime).HasDefaultValueSql("((60))");

                entity.Property(e => e.MaxWorkLong).HasDefaultValueSql("((720))");

                entity.Property(e => e.MinWorkLong).HasDefaultValueSql("((10))");

                entity.Property(e => e.OverTime).HasDefaultValueSql("((60))");

                entity.Property(e => e.OvertimeIn).HasDefaultValueSql("((60))");

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RestDays).HasDefaultValueSql("((96))");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDayLong).HasDefaultValueSql("((480))");

                entity.Property(e => e.WoverTime)
                    .HasColumnName("WOverTime")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Checkinout>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.HasIndex(e => new { e.Userid, e.CheckTime })
                    .HasName("IX_Checkinout")
                    .IsUnique();

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Exported).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenDoorFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sensorid).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CheckLog>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.Property(e => e.AttFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Checktime).HasColumnType("datetime");

                entity.Property(e => e.Checktype).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dtime)
                    .HasColumnName("DTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Opflag).HasColumnName("OPFlag");

                entity.Property(e => e.Opname)
                    .HasColumnName("OPname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sensorid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Whys)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DefineField>(entity =>
            {
                entity.HasKey(e => e.Fieldid);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasIndex(e => e.DeptName)
                    .HasName("IX_DeptName")
                    .IsUnique();

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FingerClient>(entity =>
            {
                entity.HasKey(e => e.Clientid);

                entity.HasIndex(e => e.ClientNumber)
                    .HasName("IX_ClientNumber")
                    .IsUnique();

                entity.Property(e => e.Clientid).ValueGeneratedNever();

                entity.Property(e => e.Baudrate).HasDefaultValueSql("((5))");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommPort).HasDefaultValueSql("((33302))");

                entity.Property(e => e.CommPwd)
                    .HasColumnName("CommPWD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Floorid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPaddress")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Linkmode).HasDefaultValueSql("((1))");

                entity.Property(e => e.MachineType).HasDefaultValueSql("((1))");

                entity.Property(e => e.RecStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Bdate })
                    .HasName("IX_Holiday")
                    .IsUnique();

                entity.Property(e => e.Bdate)
                    .HasColumnName("BDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeaveClass>(entity =>
            {
                entity.HasKey(e => e.Classid);

                entity.HasIndex(e => e.Classname)
                    .HasName("IX_Classname")
                    .IsUnique();

                entity.Property(e => e.Classname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAddup).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsLeave).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsTimes).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinUnit)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Showas)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Srcontrol)
                    .HasColumnName("SRControl")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Units).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MemStat>(entity =>
            {
                entity.HasKey(e => e.Lsh);

                entity.Property(e => e.Bleave).HasColumnName("BLeave");

                entity.Property(e => e.Udept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Opclient>(entity =>
            {
                entity.HasKey(e => new { e.Opid, e.ClientNumber });

                entity.ToTable("OPClient");

                entity.Property(e => e.Opid).HasColumnName("OPID");
            });

            modelBuilder.Entity<Opdept>(entity =>
            {
                entity.HasKey(e => new { e.Opid, e.DeptId });

                entity.ToTable("OPDept");

                entity.Property(e => e.Opid).HasColumnName("OPID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");
            });

            modelBuilder.Entity<Opgroup>(entity =>
            {
                entity.ToTable("OPGroup");

                entity.Property(e => e.OpgroupId).HasColumnName("OPgroupID");

                entity.Property(e => e.OpgroupName)
                    .HasColumnName("OPGroupName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpgroupPower1)
                    .HasColumnName("OPGroupPower1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower10)
                    .HasColumnName("OPGroupPower10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower11)
                    .HasColumnName("OPGroupPower11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower12)
                    .HasColumnName("OPGroupPower12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower13)
                    .HasColumnName("OPGroupPower13")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower14)
                    .HasColumnName("OPGroupPower14")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower2)
                    .HasColumnName("OPGroupPower2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower3)
                    .HasColumnName("OPGroupPower3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower4)
                    .HasColumnName("OPGroupPower4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower5)
                    .HasColumnName("OPGroupPower5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower6)
                    .HasColumnName("OPGroupPower6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower7)
                    .HasColumnName("OPGroupPower7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower8)
                    .HasColumnName("OPGroupPower8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpgroupPower9)
                    .HasColumnName("OPGroupPower9")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Opinfo>(entity =>
            {
                entity.HasKey(e => e.Opid);

                entity.ToTable("OPinfo");

                entity.HasIndex(e => e.Opname)
                    .HasName("IX_OPName")
                    .IsUnique();

                entity.Property(e => e.OpgroupId)
                    .HasColumnName("OPGroupID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Opname)
                    .IsRequired()
                    .HasColumnName("OPName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Oppwd)
                    .HasColumnName("OPPwd")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oplog>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("OPLog");

                entity.Property(e => e.Opid).HasColumnName("OPid");

                entity.Property(e => e.Oplog1)
                    .IsRequired()
                    .HasColumnName("OPlog")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Optime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OutProg>(entity =>
            {
                entity.HasKey(e => e.Progid);

                entity.Property(e => e.ProgName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgPath)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.Schid);

                entity.HasIndex(e => e.Schname)
                    .HasName("IX_Schname")
                    .IsUnique();

                entity.Property(e => e.Cycles).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.Schname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SchTime>(entity =>
            {
                entity.HasKey(e => new { e.Schid, e.BeginDay, e.Timeid });
            });

            modelBuilder.Entity<StatItems>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.Property(e => e.IsAddup)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinUnit)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Showas)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Srcontrol)
                    .HasColumnName("SRControl")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Units).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Statusid).ValueGeneratedNever();

                entity.Property(e => e.StatusChar)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeTable>(entity =>
            {
                entity.HasKey(e => e.Timeid);

                entity.HasIndex(e => e.Timename)
                    .HasName("IX_Timename")
                    .IsUnique();

                entity.Property(e => e.Bintime)
                    .IsRequired()
                    .HasColumnName("BIntime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Bouttime)
                    .IsRequired()
                    .HasColumnName("BOuttime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Eintime)
                    .IsRequired()
                    .HasColumnName("EIntime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Eouttime)
                    .IsRequired()
                    .HasColumnName("EOuttime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Intime)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsFreeTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOverTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Longtime).HasDefaultValueSql("((480))");

                entity.Property(e => e.Mofftime)
                    .HasColumnName("mofftime")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Montime)
                    .HasColumnName("montime")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MustIn).HasDefaultValueSql("((1))");

                entity.Property(e => e.MustOut).HasDefaultValueSql("((1))");

                entity.Property(e => e.Outtime)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Timename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDays)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UserAutoClass>(entity =>
            {
                entity.HasKey(e => e.Lsh);

                entity.HasIndex(e => new { e.Userid, e.Timeid })
                    .HasName("IX_UserAutoClass")
                    .IsUnique();

                entity.Property(e => e.Userid).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserFinger>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Fingerid });

                entity.Property(e => e.Fptemplate)
                    .HasColumnName("FPTemplate")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<Userinfo>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.HasIndex(e => e.UserCode)
                    .HasName("IX_Userinfo")
                    .IsUnique();

                entity.Property(e => e.Userid).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("smalldatetime");

                entity.Property(e => e.CardNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClassFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Deptid).HasDefaultValueSql("((1))");

                entity.Property(e => e.Duty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Educated)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Groupid).HasDefaultValueSql("((1))");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAtt).HasDefaultValueSql("((1))");

                entity.Property(e => e.Isovertime).HasDefaultValueSql("((1))");

                entity.Property(e => e.Isrest).HasDefaultValueSql("((1))");

                entity.Property(e => e.MgFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NativePlace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInfo).HasColumnType("image");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Polity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserLeave>(entity =>
            {
                entity.HasKey(e => e.Lsh);

                entity.HasIndex(e => new { e.Userid, e.BeginTime })
                    .HasName("IX_UserLeave")
                    .IsUnique();

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LeaveClassid).HasDefaultValueSql("((1))");

                entity.Property(e => e.Whys)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserPower>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.HasIndex(e => new { e.Userid, e.ClientNumber })
                    .HasName("IX_UserPower")
                    .IsUnique();
            });

            modelBuilder.Entity<UserShift>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Schid, e.BeginDate, e.EndDate });

                entity.Property(e => e.BeginDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserTempShift>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Timeid, e.WorkDate });

                entity.Property(e => e.WorkDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkCode>(entity =>
            {
                entity.HasKey(e => e.WorkId);

                entity.HasIndex(e => e.WorkName)
                    .HasName("IX_WorkName")
                    .IsUnique();

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e.IsAddup).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsTimes).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinUnit)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Srcontrol)
                    .HasColumnName("SRControl")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Units).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZMemAbnor>(entity =>
            {
                entity.HasKey(e => e.Lsh);

                entity.ToTable("Z_MemAbnor");

                entity.HasIndex(e => new { e.Uid, e.BeginTime })
                    .HasName("IX_Z_MemAbnor")
                    .IsUnique();

                entity.Property(e => e.AbnorShow)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeginTime)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TimeLong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ucode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Udept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Workday)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Worklong)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZMemRecord>(entity =>
            {
                entity.HasKey(e => e.Lsh);

                entity.ToTable("Z_MemRecord");

                entity.HasIndex(e => new { e.Uid, e.Checktime })
                    .HasName("IX_Z_MemRecord")
                    .IsUnique();

                entity.Property(e => e.Checktime)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Disposeplan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Errorshow)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sensorid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Timename)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UattFlag)
                    .HasColumnName("UAttFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UattFlagName)
                    .HasColumnName("UAttFlagName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ucode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Udept)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ulogid)
                    .HasColumnName("ULogid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Utypename)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uworktype)
                    .HasColumnName("UWorktype")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ZMemUclass>(entity =>
            {
                entity.HasKey(e => e.Lsh);

                entity.ToTable("Z_MemUClass");

                entity.HasIndex(e => new { e.Uid, e.Udate, e.TimeName })
                    .HasName("IX_Z_MemUClass")
                    .IsUnique();

                entity.Property(e => e.AbnorFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Aofftime)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Aofftime2)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Aontime)
                    .HasColumnName("AOntime")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Aontime2)
                    .HasColumnName("AOntime2")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Aworktime)
                    .HasColumnName("AWorktime")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Earlytime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Eofftime)
                    .HasColumnName("EOfftime")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Eontime)
                    .HasColumnName("EOntime")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Latetime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Memo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemoTime)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OffTime)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OnTime)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Sofftime)
                    .HasColumnName("SOfftime")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Sontime)
                    .HasColumnName("SOntime")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Tadd)
                    .HasColumnName("TAdd")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Tearly)
                    .HasColumnName("TEarly")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TimeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tlate)
                    .HasColumnName("TLate")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ucode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Udate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Udept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uworkname)
                    .HasColumnName("UWorkname")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Uworktime)
                    .HasColumnName("UWorktime")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WorkLong).HasDefaultValueSql("((480))");

                entity.Property(e => e.Workday)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((1))");
            });
        }
    }
}
