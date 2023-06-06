using DeliveryMental.Enums;
using Microsoft.EntityFrameworkCore;

namespace DeliveryMental.Domain.Models.TagsAggregate
{
    [Keyless]
    public class TagsViewModel
    {        
        public TagsEnum Tags { get; set; }

        public TagsViewModel() { }
    }
}
