using System;

namespace KS.RustAnalyzer.TestAdapter;

public static class Constants
{
    public const string ReleaseSummary = "Right click on Cargo.toml or examples .rs files and set command line arguments for debugging.";

    public const string RustLanguageContentType = "rust";
    public const string RustFileExtension = ".rs";
    public const string ManifestFileName = "Cargo.toml"; // NOTE: cargo.exe requires caps 'C'.
    public const string ManifestFileExtension = ".toml";

    public const string CargoExe = "cargo.exe";

    public const string ConfigurationSectionName = "rust-analyzer";

    public const string ExecutorUriString = "executor://RustTestExecutor/v1";

    public const string ManifestExtension = ".toml";

    public static readonly Version MinimumRequiredVsVersion = new (17, 4);
}