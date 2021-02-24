def cumulative_som(mijn_lijst):
    print(mijn_lijst)
    for i in range(1, len(mijn_lijst)):
        mijn_lijst[i] += mijn_lijst[i - 1]
    print(mijn_lijst)

def main():
    getallen_lijst = [2, 4, 20]

    cumulative_som(getallen_lijst)

if __name__ == '__main__':
    main()