const useApi = () => {

    const start = async (name: string) => Promise.resolve(console.log(`${name} started a game`));
    const selectCell = async (cell: number) => {
        return Promise.resolve(console.log(`selected cell ${cell}`))
    }

    return { selectCell, start };
}

export default useApi;