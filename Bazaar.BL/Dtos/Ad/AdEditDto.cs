﻿using Bazaar.BL.Dtos.AdTag;
using Bazaar.BL.Dtos.Image;

namespace Bazaar.BL.Dtos.Ad
{
    public class AdEditDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsValid { get; set; }
        public int Price { get; set; }
        public UserDto Creator { get; set; } = null!;

        public ICollection<ImageDto> Images { get; set; }

        public ICollection<AdTagDto> AdTags { get; set; }
    }
}
