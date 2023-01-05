namespace SharedLibrary.DTO.Interfaces
{
    public interface IAddressDto
    {
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}