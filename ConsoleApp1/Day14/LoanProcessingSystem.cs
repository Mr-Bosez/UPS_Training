using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day14
{

    abstract class Loan
    {
        public abstract void ApplyLoan(double loanAmount);
        public abstract void VerifyDocuments(string applicantName);
        public abstract double CalculateInterest(double loanAmount, double rate, int years);
        public abstract void SanctionLoan(double totalAmount);
    }

    
    class HomeLoan : Loan
    {
        public override void ApplyLoan(double loanAmount)
        {
            Console.WriteLine($"Home Loan applied for amount: {loanAmount}");
        }

        public override void VerifyDocuments(string applicantName)
        {
            Console.WriteLine($"Documents verified for Home Loan applicant: {applicantName}");
        }

        public override double CalculateInterest(double loanAmount, double rate, int years)
        {
            double interest = (loanAmount * rate * years) / 100;
            Console.WriteLine($"Home Loan interest calculated: {interest}");
            return interest;
        }

        public override void SanctionLoan(double totalAmount)
        {
            Console.WriteLine($"Home Loan sanctioned. Total amount to be repaid: {totalAmount}");
        }
    }

   
    class CarLoan : Loan
    {
        public override void ApplyLoan(double loanAmount)
        {
            Console.WriteLine($"Car Loan applied for amount: {loanAmount}");
        }

        public override void VerifyDocuments(string applicantName)
        {
            Console.WriteLine($"Documents verified for Car Loan applicant: {applicantName}");
        }

        public override double CalculateInterest(double loanAmount, double rate, int years)
        {
            double interest = (loanAmount * rate * years) / 100;
            Console.WriteLine($"Car Loan interest calculated: {interest}");
            return interest;
        }

        public override void SanctionLoan(double totalAmount)
        {
            Console.WriteLine($"Car Loan sanctioned. Total amount to be repaid: {totalAmount}");
        }
    }

   
    class EducationLoan : Loan
    {
        public override void ApplyLoan(double loanAmount)
        {
            Console.WriteLine($"Education Loan applied for amount: {loanAmount}");
        }

        public override void VerifyDocuments(string applicantName)
        {
            Console.WriteLine($"Documents verified for Education Loan applicant: {applicantName}");
        }

        public override double CalculateInterest(double loanAmount, double rate, int years)
        {
            double interest = (loanAmount * rate * years) / 100;
            Console.WriteLine($"Education Loan interest calculated: {interest}");
            return interest;
        }

        public override void SanctionLoan(double totalAmount)
        {
            Console.WriteLine($"Education Loan sanctioned. Total amount to be repaid: {totalAmount}");
        }
    }

  
    class LoanFactory
    {
        public static Loan GetLoan(string loanType)
        {
            switch (loanType.ToLower())
            {
                case "homeloan":
                    return new HomeLoan();
                case "carloan":
                    return new CarLoan();
                case "educationloan":
                    return new EducationLoan();
                default:
                    throw new ArgumentException("Invalid loan type requested!");
            }
        }
    }




}

