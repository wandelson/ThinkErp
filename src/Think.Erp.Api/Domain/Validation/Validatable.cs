using System.Collections.Generic;
using FluentValidation.Results;

namespace Think.Erp.Api.Validation
{
    public abstract class Validatable
    {

        public Validatable()
        {
            Notifications = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Notifications { get; private set; }

        public void AddNotification(IList<ValidationFailure> notifications)
        {
            foreach (var item in notifications)
                Notifications.Add("", item.ErrorMessage);
        }

    }
}