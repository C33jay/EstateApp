using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Reflection.Emit;
using System.Reflection;
using System.Xml.Schema;
using System.Reflection.Metadata;
using EstateApp.Web.Interfaces;
using EstateApp.Data.DatabaseContexts.ApplicationDbContext;
using System.Threading.Tasks;
using EstateApp.Web.Models;
using EstateApp.Date.Entities;

namespace EstateApp.Web.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly ApplicationDbContext  _dbContext;

        public PropertyService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddProperty(PropertyModel model)
        {
            var property = new Property
            {
                Id = Guid.NewGuid().ToString(),
                Title = model.Title,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                NumberOfRooms =model.NumberOfRooms,
                NumberOfBaths = model.NumberOfBaths,
                NumberOfToilets = model.NumberOfToilets,
                Address = model.Address,
                ContactPhoneNumber = model.ContactPhoneNumber
            };

            await _dbContext.AddAsync(property);
            await _dbContext.SaveChangesAsync();


        }
    }
}