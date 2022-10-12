using Platformer.Mechanics;
using Platformer.UI;
using UnityEngine;

namespace Platformer.UI
{
    
    /// The MetaGameController is responsible for switching control between the high level
    /// contexts of the application, eg the Main Menu and Gameplay systems.
    public class MetaGameController : MonoBehaviour
    {
        
        /// The main UI object which used for the menu.
        public MainUIController mainMenu;

        /// A list of canvas objects which are used during gameplay (when the main ui is turned off)
        public Canvas[] gamePlayCanvasii;

        /// The game controller.
        public GameController gameController;

        bool showMainCanvas = false;

        void OnEnable()
        {
            _ToggleMainMenu(showMainCanvas);
        }

        /// Turn the main menu on or off.
        public void ToggleMainMenu(bool show)
        {
            if (this.showMainCanvas != show)
            {
                _ToggleMainMenu(show);
            }
        }

        void _ToggleMainMenu(bool show)
        {
            if (show)
            {
                Time.timeScale = 0;
                mainMenu.gameObject.SetActive(true);
                foreach (var i in gamePlayCanvasii) i.gameObject.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                mainMenu.gameObject.SetActive(false);
                foreach (var i in gamePlayCanvasii) i.gameObject.SetActive(true);
            }
            this.showMainCanvas = show;
        }

        void Update()
        {
            if (Input.GetButtonDown("Menu"))
            {
                ToggleMainMenu(show: !showMainCanvas);
            }
        }

    }
}
