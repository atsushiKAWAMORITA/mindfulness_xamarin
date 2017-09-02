using System;
using Reactive.Bindings;
using System.Reactive.Linq;
namespace mindfulness.ViewModels
{
    public class mindfulnessViewModel
    {
#region private parameters
        private readonly ReactiveProperty<string> _buttonStartText
            = new ReactiveProperty<string>(@"Start!");
        private readonly ReactiveProperty<string> _buttonPauseText
            = new ReactiveProperty<string>(@"Pause!");
        private readonly ReactiveProperty<string> _buttonConfigText
            = new ReactiveProperty<string>(@"Go To Config");
#endregion

        public ReactiveProperty<string> ButtonStartText
        {
            get { return _buttonStartText; }   
        }
        public ReactiveProperty<string> ButtonPauseText
        {
            get { return _buttonPauseText; }    
        }
        public ReactiveProperty<string> ButtonConfigText
        {
            get { return _buttonConfigText; }
        }
        public ReactiveProperty<string> LavelLapseTime
        {
            get; private set;
        }
        public ReactiveCommand Start
        {
            get; private set;    
        }
        public ReactiveCommand Pause
        {
            get; private set;
        }
        public ReactiveCommand GoToConfig
        {
            get; private set;
        }

        private mindfulness.Models.mindfulnessModel _model;
        public mindfulnessViewModel()
        {
            _model = new Models.mindfulnessModel();
            Start = new ReactiveCommand();
            Start.Subscribe(_ => {
                
            });
            Pause = new ReactiveCommand();
            Pause.Subscribe(_ => {
                
            });
            GoToConfig = new ReactiveCommand();
            GoToConfig.Subscribe(_ => {

            });
        }

    }
}
