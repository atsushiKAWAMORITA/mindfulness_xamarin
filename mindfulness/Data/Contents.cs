using System;
using System.Collections.Generic;
namespace mindfulness.Data
{
    public class Contents
    {
        private Dictionary<int, string> _mainContents;
        public Dictionary<int, string> MainContents
        {
            get { return _mainContents; }
        }
        private Dictionary<int, string> _subContents;
        public Dictionary<int, string> SubContents
        {
            get { return _subContents; }
        }
        public Contents()
        {
            SetContents();
        }
        private void SetContents()
        {
			_mainContents = new Dictionary<int, string>();
			_subContents = new Dictionary<int, string>();
			//Step 1
            _mainContents.Add(1, @"背筋を伸ばして、両肩を結ぶ線がまっすぐになるように座り、目を閉じる");
			_subContents.Add(1, @"脚を組んでも、正座でも、椅子に座っても良いです。「背筋が伸びてその他の体の力は抜けている」楽な姿勢を見つけて下さい。");
			//Step 2
            _mainContents.Add(2, @"呼吸をあるがままに感じる");
			_subContents.Add(2, @"呼吸をコントロールしないで、身体がそうしたいようにさせます。そして呼吸に伴ってお腹や胸がふくらんだり縮んだりする感覚に注意を向け、その感覚の変化を気づきが追いかけていくようにします。
例えば、お腹や胸に感じる感覚が変化する様子を、心の中で、「ふくらみ、ふくらみ、縮み、縮み」などと実況すると感じやすくなります。");
			//Step 3
            _mainContents.Add(3, @"わいてくる雑念や感情にとらわれない");
			_subContents.Add(3, @"単純な作業なので、「仕事のメールしなくちゃ」「ゴミ捨て忘れちゃった」など雑念が浮かんできます。そうしたら「雑念、雑念」と心の中でつぶやき、考えを切り上げ、「戻ります」と唱えて、呼吸に注意を戻します。
「あいつには負けたくない」など考えてしまっている場合には、感情が動き始めています。「怒り、怒り」などと心の中でつぶやき、「戻ります」と唱えて、呼吸に注意を戻します。");
			//Step 4
            _mainContents.Add(4, @"身体全体で呼吸するようにする");
			_subContents.Add(4, @"次に、注意のフォーカスを広げて、「今の瞬間」の現実を幅広く捉えるようにしていきます。最初は、身体全体で呼吸をするように、吸った息が手足の先まで流れ込んでいくように、吐く息が身体の隅々から流れ出ていくように感じながら、「ふくらみ、ふくらみ、縮み、縮み」と実況を続けていきます。");
			//Step 5
            _mainContents.Add(5, @"身体の外にまで注意のフォーカスを広げていく");
			_subContents.Add(5, @"さらに、自分の周りの空間の隅々に気を配り、そこで気づくことのできる現実の全てを見守るようにしていきます。自分を取り巻く部屋の空気の動き、温度、広さなどを感じ、さらに外側の空間にも（部屋の外の音などに対しても）気を配っていきます。それと同時に「ふくらみ、ふくらみ、縮み、縮み」と実況は続けますが、そちらに向ける注意は弱くなり、何か雑念が出てきたことに気づいても、その辺りに漂わせておくようにして（「戻ります」とはせずに）、消えていくのを見届けます。");
			//Step 6
            _mainContents.Add(6, @"瞑想を終了する");
			_subContents.Add(6, @"まぶたの裏に注意を向け、そっと目を開けていきます。伸びをしたり、身体をさすったりして、普段の自分に戻ります。");
		}
    }
}
