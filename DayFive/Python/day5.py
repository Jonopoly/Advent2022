stacks = []

f = open('input.txt', 'r')
data = f.read()

for line in data.strip().split('\n'):
    if line.startswith('[') and line.endswith(']'):
        # This line represents a stack of crates
        crates = line[1:-1].split()
        stacks.append(crates)
    else:
        # This line represents a rearrangement step
        # Split the line into its parts
        source, _, num_crates, _, _, _, _, _, dest = line.split()
        # Remove the specified number of crates from the source stack
        source_stack = stacks[int(source) - 1]
        crates = source_stack[-int(num_crates):]
        source_stack = source_stack[:-int(num_crates)]
        # Append the crates to the destination stack
        dest_stack = stacks[int(dest) - 1]
        dest_stack += crates

# Determine the final arrangement of crates
top_crates = [stack[-1] for stack in stacks]
print(''.join(top_crates))