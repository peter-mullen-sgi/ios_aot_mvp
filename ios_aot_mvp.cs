using System.Runtime.InteropServices;

namespace ios_aot_mvp;


public static class ios_aot_mvp_api
{
    [UnmanagedCallersOnly( EntryPoint="sample_api_call" )]
    public static int SampleApiCall()
    {
        return 42;
    }
}
