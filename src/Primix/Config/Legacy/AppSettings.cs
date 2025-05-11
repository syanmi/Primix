using System;

namespace Primix.Config.Legacy
{
    public class AppSettings : XmlDocumentDataSource
    {
        private AppSettings(string path) : base(path)
        {
        }

        public AppSettingSectionA SectionA
        {
            get => GetSection<AppSettingSectionA>();
            set => SetSection(value);
        }

        public new static AppSettings Load(string path) 
        {
            var settings = new AppSettings(path);

            settings.Load();

            return settings;
        }
    }

    public class AppSettingSectionA
    {
        public string Name => "AppSetinngTestA";
    }
}
