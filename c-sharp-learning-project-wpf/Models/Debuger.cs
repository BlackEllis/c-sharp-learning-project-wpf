using System.Collections.Generic;
using System.Linq;

namespace c_sharp_learning_project_wpf.Models
{
    class Debuger
    {
        private List<string> _log_texts;

        public Debuger()
        {
            if (_log_texts != null) return;
            _log_texts = new List<string>();
        }

        public string log_text
        {
            set
            {
                _log_texts.Add(value);
            }
        }

        public List<string> log_texts
        {
            get
            {
                return _log_texts;
            }
        }
    }
}
