# Memory Game

**Created by:** Hanoch Padwa

## Game Overview

The Memory Game is a single-player card-matching experience presented as a **4×4 grid** of **16 cards**. Each card shows a **question mark** on the front and a **picture** on the back. Every picture appears **exactly twice**, forming matching pairs. The interface includes a **top toolbar** with **Start** and **Restart** buttons plus counters for **Moves Taken** and **Sets Found**, and a **center label** that guides the player before and after play.

## Rules and Objectives

- **Objective:** Find all matching pairs before exceeding the allowed mistake threshold.
- **Mistake threshold:** A maximum of **5 mismatched attempts** is allowed; this is tracked as **Moves Taken − Sets Found**.
- **Initial state:** All cards and buttons are disabled; the center label displays *"Click the Start button to start playing"*.
- **Starting play:** Clicking **Start** removes the center label, enables all cards, and ignores further Start clicks until a restart.
- **Card matching rules:**
  - The player flips **two cards at a time**.
  - After the second selection, the game checks for a match.
  - `Moves Taken` increments by **1** after every pair of selections.
  - **If the cards match:**
    - `Sets Found` increments by **1**.
    - The matched cards are removed from the board.
  - **If the cards do not match:** The cards are flipped back.
- **Restarting:** Clicking **Restart** at any time returns the game to the initial state; all progress is cleared and the player must click **Start** again.

## Player Interactions

<<<<<<< HEAD
The game is presented as a **5×4 grid** containing **16 cards**.
=======
- **Start button:** Begins the game, removes the center label, and enables card interactions; subsequent clicks are ignored until a restart.
- **Restart button:** Resets the board, counters, and label to the initial pre-start state.
- **Card selection:**
  1. Clicking the **first card** reveals its picture and waits for the second selection.
  2. Clicking the **second card** triggers the match check and updates counters according to the rules above; matched pairs remain removed/disabled while non-matching pairs flip back.
>>>>>>> 7a69918bc67bb961ed82bdc64921d98c86db5515

## Win/Loss Conditions

- **Win:** When all matching pairs are found, a center label announces the win, the game ends, and the interface returns to the initial pre-start state.
- **Loss:** If the difference between **Moves Taken** and **Sets Found** exceeds **5**, the player loses and the game terminates.

## Notes

- Only **single-player** is supported.
- No multiplayer or AI functionality is required.
