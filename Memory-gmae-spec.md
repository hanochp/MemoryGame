# Memory Game

**Created by:** Hanoch Padwa

## Overview

This document describes the requirements for the software implementation of the classic **Memory Game**.  
The game is designed for **single-player** use only.

The document includes:
- A description of the game mechanics
- Functional and UI requirements
- Game rules and behavior

---

## The Game

The game is presented as a **4×4 grid** containing **16 cards**.

- Each card has:
  - A **question mark** on the front
  - A **picture** on the back
- Each picture appears **exactly twice**, forming a matching pair

### Gameplay

- The player flips **two cards at a time** to try to find a matching pair.
- If the two cards match:
  - The pair is considered a **set**
  - The two cards are **removed from the board**
- If they do not match:
  - The cards are flipped back

### Scoring & Game Over

- The game tracks:
  - **Moves Taken**
  - **Sets Found**
- These values are displayed in the **top toolbar**
- If the difference between **Moves Taken** and **Sets Found** exceeds **5**, the player **loses** and the game ends

---

## Software Implementation

### UI Elements

The application must include the following UI components:

- A **4×4 grid of cards**
- A **hidden label in the center** that displays:
  > *"Click the Start button to start playing"*
- A **top toolbar** containing:
  - **Start** button
  - **Restart** button
  - **Moves Taken** counter
  - **Sets Found** counter

---

## Game Process & Rules

### Initial State

- When the application loads:
  - All cards and buttons are **disabled**
  - The center label is visible:
    > *"Click Start to start game"*

### Start Game

- When the **Start** button is clicked:
  - The center label is removed
  - All cards are enabled
  - Further clicks on the **Start** button are ignored

### Card Selection

1. When the player clicks the **first card**:
   - The card’s picture is revealed
   - The game waits for the second card selection

2. When the player clicks the **second card**:
   - The game checks for a match

### Match Logic

- **If the cards match**:
  - `Sets Found` increments by **1**
  - `Moves Taken` increments by **1**
  - The matched cards are removed from the board

- **If the cards do not match**:
  - `Moves Taken` increments by **1**
  - The cards are flipped back

### Restart Game

- If the player clicks **Restart** at any time:
  - The game resets to its initial state
  - All progress is cleared
  - The player must click **Start** again

### Win Condition

- When the player finds **all matching sets**:
  - A label appears in the center saying the player has **won**
  - The game is terminated
  - The game returns to the initial pre-start state

---

## Notes

- Only one player is supported
- No multiplayer or AI functionality is required