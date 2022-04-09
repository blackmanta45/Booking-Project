using Microsoft.AspNetCore.Mvc;

namespace Presentation.Pages.Components.ValidationAlert
{
    public class ValidationAlertViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title) =>
            this.View(new ValidationAlertModel
            {
                Title = title
            });
    }
}
