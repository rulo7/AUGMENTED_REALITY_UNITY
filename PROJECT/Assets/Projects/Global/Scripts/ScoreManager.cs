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

	public int incr(int points){
		gameScore+=points;
		return this.gameScore;
	}

	public int decr(int points){
		if (gameScore - points > 0)
			gameScore -= points;
		else
			gameScore = 0;

		return this.gameScore;
	}
}
