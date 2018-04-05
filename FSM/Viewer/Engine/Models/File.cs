using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Application.Engine.Models
{
    public class File
    {
        [DataMember(Name = "path")]
        public string Path { get; set; }
        [DataMember(Name = "url")]
        public string Url { get; set; }
        [DataMember(Name = "line")]
        public int Line { get; set; }
        [DataMember(Name = "code")]
        public string Code { get; set; }
        //[DataMember(Name = "reviewed")]
        //public bool Reviewed { get; set; }
        //[DataMember(Name = "flagged")]
        //public bool Flagged { get; set; }

        public File()
        {

        }
    }

    /*
    {
        "path":     "M:\\Code\\TFS\\FIPS\\DEV\\Core\\OnBase.Cpp\\Applications\\Barcoder\\lib_keywordpanel\\KeywordPanel.cpp",
        "url":      "http://srv-tfsat01:8080/tfs/HylandCollection/OnBase/_versionControl?path=%24%2FOnBase%2FDEV%2FCore%2FOnBase.Cpp%2FApplications%2FBarcoder%2Flib_keywordpanel%2FKeywordPanel.cpp&_a=contents&line=768&lineStyle=plain",
        "line":     768,
        "code":     "BOOL CKeywordPanel::_keywordExistsThatIsBlank(nkp::CKeyword* pkCompare, nkp::CKeyword** ppRes, MAPKEYWORDSAF* pMap)"
    }
    */

    public class Files
    {
        public File[] All { set; get; }
    }
}

