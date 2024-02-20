
    var audio = null;

    function playAudio(soundControl) {
        if (audio) {
        audio.pause();
        }

        switch (soundControl) {

            case 1:
        audio = new Audio('/mp3/motor1.mp3');
        audio.play();
        break;

    case 2:
        audio = new Audio('/mp3/tuta.mp3');
        audio.play();
        break;
    case 3:
        audio = new Audio('/mp3/motor2.mp3');
        audio.play();
         break;

    case 4:

        audio = new Audio('/mp3/rosatuut.mp3');

        audio.play();
        break;
        }
    }

