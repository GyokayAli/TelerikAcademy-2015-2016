/*Problem 11. Version attribute
Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
Apply the version attribute to a sample class and display its version at runtime.
 */

namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
        AttributeTargets.Method | AttributeTargets.Enum, AllowMultiple = true)]

    public class VersionAttribute : Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public VersionAttribute(string input)
        {
            var name = input.Split('.');
            this.Major = int.Parse(name[0]);
            this.Minor = int.Parse(name[1]);
        }
    }
}
