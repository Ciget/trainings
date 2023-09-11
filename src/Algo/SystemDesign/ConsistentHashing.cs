namespace Algo.SystemDesign;
using System;
using System.Collections.Generic;
using System.Linq;

public class Server
{
    public String ipAddress;
    public Server(String ipAddress)
    {
        this.ipAddress = ipAddress;
    }
}

public static class FNVHash
{
    public static uint To32BitFnv1aHash(string toHash, bool separateUpperByte = false)
    {
        IEnumerable<byte> bytesToHash;
        if (separateUpperByte)
            bytesToHash = toHash.ToCharArray()
                .Select(c => new[] { (byte)((c - (byte)c) >> 8), (byte)c })
                .SelectMany(c => c);
        else
            bytesToHash = toHash.ToCharArray()
                .Select(Convert.ToByte);
        //this is the actual hash function; very simple
        uint hash = FnvConstants.FnvOffset32;
        foreach (var chunk in bytesToHash)
        {
            hash ^= chunk;
            hash *= FnvConstants.FnvPrime32;
        }
        return hash;
    }
}
public static class FnvConstants
{
    public static readonly uint FnvPrime32 = 16777619;
    public static readonly ulong FnvPrime64 = 1099511628211;
    public static readonly uint FnvOffset32 = 2166136261;
    public static readonly ulong FnvOffset64 = 14695981039346656037;
}

public class ConsistentHash
{
    private SortedDictionary<uint, Server> hashRing;
    private int numberOfReplicas; // The number of virtual nodes

    public ConsistentHash(int numberOfReplicas, List<Server> servers)
    {
        this.numberOfReplicas = numberOfReplicas;

        hashRing = new SortedDictionary<uint, Server>();

        if(servers != null)
        foreach(Server s in servers)
        {
            this.addServerToHashRing(s);
        }
    }

    public void addServerToHashRing(Server server)
    {
        for(int i=0; i < numberOfReplicas; i++)
        {
            //Fuse the server ip with the replica number
            string serverIdentity = String.Concat(server.ipAddress, ":", i);
            //Get the hash key of the server
            uint hashKey = FNVHash.To32BitFnv1aHash(serverIdentity);
            //Insert the server at the hashkey in the Sorted Dictionary
            this.hashRing.Add(hashKey, server);
        }
    }

    public void removeServerFromHashRing(Server server)
    {
        for (int i = 0; i < numberOfReplicas; i++)
        {
            //Fuse the server ip with the replica number
            string serverIdentity = String.Concat(server.ipAddress, ":", i);
            //Get the hash key of the server
            uint hashKey = FNVHash.To32BitFnv1aHash(serverIdentity);
            //Insert the server at the hashkey in the Sorted Dictionary
            this.hashRing.Remove(hashKey);
        }
    }

    // Get the Physical server where a key is mapped to
    public Server GetServerForKey(String key)
    {
        Server serverHoldingKey;

        if(this.hashRing.Count==0)
        {
            return null;
        }

        // Get the hash for the key
        uint hashKey = FNVHash.To32BitFnv1aHash(key);

        if(this.hashRing.ContainsKey(hashKey))
        {

            serverHoldingKey = this.hashRing[hashKey];
        }
        else
        {
            uint[] sortedKeys = this.hashRing.Keys.ToArray();

            //Find the first server key greater than  the hashkey
            uint firstServerKey = sortedKeys.FirstOrDefault(x => x >= hashKey);

            // Get the Server at that Hashkey
            serverHoldingKey = this.hashRing[firstServerKey];
        }

        return serverHoldingKey;
    }

}