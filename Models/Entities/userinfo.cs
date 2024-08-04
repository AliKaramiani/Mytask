public class userinfo:Parent
{
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public bool IsMarried { get; set; }
    public string Skills { get; set; }
    //بارگذاری مدرک
    public string ResumePath { get; set; }
    public string SelectedJob { get; set; }



    public userinfo()
    {
        this.Name = null;
        this.Lastname = null;
        this.PhoneNumber = null;
        this.Address = null;
      
        this.Skills = null;
        this.ResumePath = null;
        this.SelectedJob = null;
        
    }
}