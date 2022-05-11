using FluentValidation;
using System;

namespace CovidVaccinationProject.Model
{
    public class Patients
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public int EmiratesId { get; set; }
        public int Gender { get; set; }
        public int MartialStatus { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string FullAddress { get; set; }
        public string VaccinationCenter { get; set; }
        public DateTime VaccinationDate { get; set; }
        public string DoseNo { get; set; }
        public string DoseName { get; set; }
    }
    public class PatientsValidator : AbstractValidator<Patients>
    {
        public PatientsValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.PatientName).NotEmpty().Length(0, 50);
            RuleFor(x => x.MobileNo).NotEmpty().Matches("^(?:\\+971|00971|0)?(?:50|51|52|55|56|2|3|4|6|7|9)\\d{7}$");
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.EmiratesId).NotEmpty();
            RuleFor(x => x.Gender).NotEmpty();
            RuleFor(x => x.MartialStatus).NotEmpty();
            RuleFor(x => x.FullAddress).NotEmpty();
            RuleFor(x => x.VaccinationDate).NotEmpty();
            RuleFor(x => x.DoseNo).NotEmpty();
            RuleFor(x => x.DoseName).NotEmpty();
        }
    }
}
