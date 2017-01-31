using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_learning_project_wpf.Models
{
    class Utility
    {
        public static Dictionary<string, string> argument_parser(string[] src_str_array)
        {
            Dictionary<string, string> dst_hash_array = new Dictionary<string, string>();

            // コマンド引数を要素毎に取り出す
            foreach (String str in src_str_array)
            {
                string element = str;

                // 1要素からパラメータ名と値分割する
                string[] str_array = element.Split('=');
                if (str_array.Count() > 1)　// パラメータ名と値が切り分けれない
                    dst_hash_array.Add(str_array[0], str_array[1]); // 切り分けたキーと値の格納
                else
                    dst_hash_array.Add(str_array[0], str_array[0]); // キー名と値が同じ
            }

            return dst_hash_array;
        }
    }
}
