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

    const playMove = async (gameId: string, cell: number) => {

        const response = await fetch(`${baseUrl}/api/games/${gameId}/play-move`,{
            method: 'POST',
            body: JSON.stringify({ gameId, cell, value: 'X' }),
            headers: { 'Content-Type': 'application/json;charset=UTF-8' },
        });

        if (!response.ok) throw Error("Move was not saved");

        return await response.json();
    }

    return { playMove, start };
}

export default useApi;