public class ScoreManager {
	
	private static ScoreManager instance;
	public static ScoreManager getInstance(){
		if (instance == null)
			instance = new ScoreManager ();

		return instance;
	}

	private int gameScore = 0;

	public int getGameScore(){
		return this.gameScore;
	}

	public int pointUp(){
		gameScore++;
		return this.gameScore;
	}
}
