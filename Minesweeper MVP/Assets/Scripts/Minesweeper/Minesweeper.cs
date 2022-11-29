using JGM.Minesweeper.Controllers;
using JGM.Minesweeper.Views;
using UnityEngine;

namespace JGM.Minesweeper
{
    [RequireComponent(typeof(IMinesweeperView))]
    public class Minesweeper : MonoBehaviour
    {
        private IMinesweeperView minesweeperView;
        private IMinesweeperController minesweeperController;

        private void Awake()
        {
            minesweeperView = gameObject.GetComponent<IMinesweeperView>();
            minesweeperController = new MinesweeperController();
            minesweeperController.StartGame();
        }
    }
}