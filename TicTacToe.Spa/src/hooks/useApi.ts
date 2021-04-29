import Game from "../interfaces/Game";

const useApi = (baseUrl: string) => {

    const start = async (name: string): Promise<Game> => {
        const response = await fetch(`${baseUrl}/api/games/start`, {
            method: 'POST',
            body: JSON.stringify({ playerName: name }),
            headers: { 'Content-Type': 'application/json;charset=UTF-8' },
        });

        if (!response.ok) throw Error("Unable to start game");

        return await response.json();
    };

    const selectCell = async (cell: number) => {
        return Promise.resolve(console.log(`selected cell ${cell}`))
    }

    return { selectCell, start };
}

export default useApi;