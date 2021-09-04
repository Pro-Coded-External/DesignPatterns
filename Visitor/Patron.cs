using System;
using System.Collections.Generic;

namespace Visitor
{
    /// <summary>
    ///     The Visitor interface, which declares a Visit operation for each Concrete Visitor to implement.
    /// </summary>
    internal interface IVisitor
    {
        void Visit(Element element);
    }

    /// <summary>
    ///     A Concrete Visitor class.
    /// </summary>
    internal class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;

            // We've had a great year, so 10% pay raises for everyone!
            employee.AnnualSalary *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name,
                employee.AnnualSalary);
        }
    }

    /// <summary>
    ///     A Concrete Visitor class
    /// </summary>
    internal class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;

            // And because you all helped have such a great year, all my employees get three extra paid time off days each!
            employee.PaidTimeOffDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name,
                employee.PaidTimeOffDays);
        }
    }

    /// <summary>
    ///     The Element abstract class.  All this does is define an Accept operation, which needs to be implemented by any
    ///     class that can be visited.
    /// </summary>
    internal abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    /// <summary>
    ///     The Concrete Element class, which implements all operations defined by the Element.
    /// </summary>
    internal class Employee : Element
    {
        public Employee(string name, double annualSalary, int paidTimeOffDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidTimeOffDays = paidTimeOffDays;
        }

        public double AnnualSalary { get; set; }
        public string Name { get; set; }
        public int PaidTimeOffDays { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    ///     The Object Structure class, which is a collection of Concrete Elements.  This could be implemented using another
    ///     pattern such as Composite.
    /// </summary>
    internal class Employees
    {
        private readonly List<Employee> _employees = new();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var e in _employees) e.Accept(visitor);
            Console.WriteLine();
        }
    }

    internal class LineCook : Employee
    {
        public LineCook() : base("Dmitri", 32000, 7)
        {
        }
    }

    internal class HeadChef : Employee
    {
        public HeadChef() : base("Jackson", 69015, 21)
        {
        }
    }

    internal class GeneralManager : Employee
    {
        public GeneralManager() : base("Amanda", 78000, 24)
        {
        }
    }
}