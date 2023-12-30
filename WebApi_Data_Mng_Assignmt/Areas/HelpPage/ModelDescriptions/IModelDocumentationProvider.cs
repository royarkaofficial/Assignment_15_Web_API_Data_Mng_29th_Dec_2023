using System;
using System.Reflection;

namespace WebApi_Data_Mng_Assignmt.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}