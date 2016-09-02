namespace WebApplication.Models 
{

    /** Use of virtual to address issue with dependency loop. */
    public class Score 
    {

        public virtual int Id { get; set; }
        public virtual int Value { get; set; }
        public virtual Player Player { get; set; }

    }

}
