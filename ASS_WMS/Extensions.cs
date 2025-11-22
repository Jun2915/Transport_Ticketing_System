using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ASS_WMS;

public static class Extensions
{
    public static bool IsValid(this ModelStateDictionary ms , string key)
    {
        return ms.GetFieldValidationState(key) == ModelValidationState.Valid;
    }
}