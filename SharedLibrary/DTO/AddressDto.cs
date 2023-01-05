using SharedLibrary.DTO.Interfaces;

namespace SharedLibrary.DTO
{
    public class AddressDto : IAddressDto
    {
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}