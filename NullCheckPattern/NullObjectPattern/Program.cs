using NullObjectPattern.Entities;
using NullObjectPattern.Services;
using NullObjectPattern.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    /*
     * Null Object pattern is going to be used every time 
     * you have a null object being returned when you have to check if someting
     * is equal to null.
     * The idea behind of object pattern is that you will use an object which will be 
     * returned instead of null that have the exact same signature exact same proeprties
     * Treat this object that is being returned frrom this method for example 
     * this null obnject 
     * If you have an item and this item may or may not have an image so when you get
     * the image of an item it will either be null or it will be an image you would have 
     * to check every time that you use that image , before you do anything if it;s null
     * and if it is null show some default image for example etc.
     * 
     * If you use an null object pattern this image property will just return a null object
     * of the image which would just be a default image for example that would be displayed
     * instead of the actual image
     * 
     * With this pattern you will stop writing null checks 
     * The Null Object Pattern 
     * 
     * Person (+FirstName, + LastName) ---> PersonView ---> +PersonView.Render()
     * NullPerson (+FirstName, +LastName)
     * 
     * Origins of Null
     * Null Checks 
     * Writing Null Checks
     * Eliminate the need for null checks 
     * 
     * public class PersonView
     * {
     *      public PersonView(Person person)
     *      {
     *      // cyclomatic complexity score of six
     *      // code complexity is rising 
     *          if(person == null)throw new ArgumentNullException();
     *          if(person.FirstName == null) throw new ArumentNullException();
     *          if(person.LastName == null) throw new ArgumentNullException();
     *      }
     * }
     * 
     * How many times we write this code , particularly in View constructors for 
     * web applications , or in controllers. A null check is practically a requiremnt
     * when accepting nullable arguments into functions or constructors
     * Each null check increases a measure known a cyclomatic complexity, 
     * which is a measure of the number of logical branches in your code .
     * Bigger numbers are bad
     * 
     * The programm calling Person.Render may not know that the Person object needed
     * for rendering has not been intialized, this is a recipe for null reference exception
     * to be thrown by the PersonView Class 
     * But what if there are a default implemntation of the Person Class? 
     * PersonView can use the NullPerson Type in its render method and not worry about 
     * getting a null reference exception 
     * One way to implement NullPerson is through inheritance
     * or implement a coomon interface IPerson which is used by the Person class
     * 
     * NullPerson.cs
     * public class NullPerson : IPerson
     * {
     *      public string FirstName
     *      {
     *          get { return "David"; }
     *      }
     *      
     *      public string LastName
     *      {
     *          get { return "Starr"; }    
     *      }
     * }
     * 
     * public class PersonView
     * {
     *      private readonly Person _person;
     *      
     *      public PersonView(Person person)
     *      {
     *          _person = person;
     *      }
     * }
     * 
     * The real goodness come when recipient of person type can always 
     * depend on the person being non-null. Now we no need to perform any 
     * null checks, our code complexity score drops, our code comprehendion increases
     * , fewer line of codes are needed
     * 
     * 
     * 
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            LearnerService learnerService = new LearnerService();
            ILearner learner = learnerService.GetCurrentLearner();

            LearnerView view = new LearnerView(learner);
            view.RenderView();
        }
    }
}

/*
 * 
 * Person
 * + FirstName ---------|        |                         |
 * + LastName  ---------| IPerson|                         |  
 *                      |        |-------PersonView--------|---- Program or Controller
 * NullPerson           |        |                         |     PersonView.Render();
 * + FirstName ---------| IPerson|                         |
 * + LastName  ---------|        |
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
