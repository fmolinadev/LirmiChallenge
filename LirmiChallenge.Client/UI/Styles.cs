using MudBlazor;

namespace LirmiChallenge.Client.UI
{
    public class LirmiStyles
    {
        public string BrandingSkyblue { get; set; } = "#36bbda";
        public string BrandingViolet { get; set; } = "#5016e1";
        public string BrandingYellow { get; set; } = "#f7d718";
        public string BrandingPink { get; set; } = "#bd1dda";
        public string ColorBackground { get; set; } = "#ffffff"; 

        public string ColorBorder { get; set; } = "#eeeeee"; 
        public string  ColorTextLight { get; set; } = "#ffffffff"; 
        public string  ColorTextDark { get; set; } = "#1a1a27"; 
        public int BorderRadius { get; set; } = 10; 
        public int Spacer { get; set; } = 18;    

    }

    public static class Styles
    {
        public static readonly LirmiStyles LirmiStyles = new();

    
       
    }
}