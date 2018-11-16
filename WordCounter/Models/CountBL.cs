namespace WordCounter.Models {
    public class CountBL {
        private string _word;
        private string _sentance;

        public CountBL () {

        }

        public CountBL (string word) {
            _word = word;
        }

        public CountBL (string word, string sentance) {
            _word = word;
            _sentance = sentance;
        }

        public string GetWord () {
            return _word;
        }

        public string GetSentance() {
            return _sentance;
        }
    }
}