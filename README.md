# Candidate-Tech-Test-1
Longest Rising Sequence Finder is a tool designed to identify and extract the longest rising sequence from a given set of integers.
# Longest Rising Sequence Finder

**Longest Rising Sequence Finder** is a tool designed to identify and extract the longest rising sequence from a given collection of integers.

## Algorithm Logic

1. **Initialization**:
   - Maximum length (`max`) is set to 1.
   - Current consecutive sequence length (`current`) set to 1.
   - Ending indices (`End` & `EndIndex`) set to 0.

2. **Traversal**:
   - Traverse the integer list starting from the second element.

3. **Comparison**:
   - For each element, check if the current element is greater than the previous one.
   - If yes, increment the `current` count and update the `EndIndex`.

4. **Update Maximum**:
   - Check if `current` surpasses `max`. If so, update `max` and `End`.

5. **Reset**:
   - If the current element isn't greater than the previous one, reset `current` to 1.

6. **Extraction**:
   - Once the traversal is done, use `End` and `max` to extract and return the longest rising sequence.

## Testing

### How to Run Tests

To run tests, execute the following:

```bash
dotnet test
```

## Test Scenarios

The tool has been tested against various scenarios to ensure its accuracy and robustness:

- **Regular Rising Sequence**:
    - **Input**: [4,3,5,8,5,0,0,-3]
    - **Expected Output**: [3,5,8]

- **Sequence with Negatives**:
    - **Input**: [4, 6, -3, 3, 7, 9]
    - **Expected Output**: [-3, 3, 7, 9]

- **Two Consecutive Rising Elements**:
    - **Input**: [9, 6, 4, 5, 2, 0]
    - **Expected Output**: [4, 5]

- **Completely Rising Sequence**:
    - **Input**: [-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5]
    - **Expected Output**: [-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5]

- **Completely Falling Sequence**:
    - **Input**: [5, 4, 3, 2, 1, 0, -1, -2, -3, -4, -5]
    - **Expected Output**: [5]

- **Empty Array**:
    - **Input**: []
    - **Expected Output**: []
 
- **Single Element Sequence**:
    - **Input**: [5]
    - **Expected Output**: [5]
