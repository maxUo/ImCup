namespace ImCup.Model {
   public class BlankBaseView : BaseView {
       BlankBaseView()
       {
           Text = "";

           ImageFon = "";
           ImageFonGridColumnSpan = "1";
           ImageFonGridRowSpan = "1";

           AnimationLeft = "";
           AnimationLeftColumnSpan = "1";
           AnimationLeftRowSpan = "1";

           AnimationRight = "";
           AnimationRightGridColumnSpan = "1";
           AnimationRightGridRowSpan = "1";

           ImageLeft = "";
           ImageLeftGridColumnSpan = "1";
           ImageLeftGridRowSpan = "1";

           ImageRight = "";
           ImageRightGridRowSpan = "1";
           ImageRightGridColumnSpan = "1";

           NavigationImageLeft = "";
           NavigationImageRight = "";
           NavigationLeftButtonIsEnabled = "false";
           NavigationRightButtonIsEnabled = "false";
       }
    }
}
