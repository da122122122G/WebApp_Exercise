using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Exercise.Models
{
    /// <summary>
    /// リスト3-3 
    /// フォームデータを保持するViewModel
    /// </summary>
    public class SampleForm
    {
        /// <summary>
        /// 氏名プロパティ
        /// </summary>
        /// <value></value>
        public string? Name { get; set; }
        /// <summary>
        /// 年齢プロパティ
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
    }
}