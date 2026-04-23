using System.Diagnostics;

public static class ExceptionLogger
{
    public static string Format(Exception ex, string message)
    {
        var trace = new StackTrace(ex, true);
        var frame = trace.GetFrames()?.LastOrDefault();

        string file = Path.GetFileName(frame?.GetFileName() ?? "unknown");
        int line = frame?.GetFileLineNumber() ?? 0;
        string method = frame?.GetMethod()?.Name ?? "unknown";

        var emoji = ExceptionEmojiMapper.GetEmoji(ex);

        return $"""
        ─────────────────────────────
        💥 EXCEPTION
        📌 Message: {message}
        📄 File: {file}
        🔢 Line: {line}
        🧠 Method: {method}
        {emoji}: {ex.GetType().Name}
        ─────────────────────────────
        """;
    }

    public static void Log(Exception ex, string message)
    {
        Console.WriteLine(Format(ex, message));
    }
}

public static class ExceptionEmojiMapper
{
    public static string GetEmoji(Exception ex)
    {
        return ex switch
        {
            // 🧠 Referência
            NullReferenceException => "🧠",

            // ⚠️ Validação
            ArgumentException => "⚠️",
            FormatException => "⚠️",
            InvalidOperationException => "⚠️",

            // 🔢 Numérico
            OverflowException => "🔢",
            DivideByZeroException => "🔢",

            // 📂 IO
            IOException => "📂",
            //FileNotFoundException => "📂",
            //DirectoryNotFoundException => "📂",

            // 🌐 Rede
            HttpRequestException => "🌐",
            TaskCanceledException => "🌐",

            // 🔐 Segurança
            UnauthorizedAccessException => "🔐",

            // ⏳ Timeout
            TimeoutException => "⏳",

            // ⚙️ Sistema
            SystemException => "⚙️",

            // ❌ Default
            _ => "❌"
        };
    }
}